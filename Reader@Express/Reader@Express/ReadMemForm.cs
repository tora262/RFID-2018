using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using idro.reader.api;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Reader_Express.DAL;
using Reader_Express.OBJECT;

namespace Reader_Express
{
    public partial class ReadMemForm : DevExpress.XtraEditors.XtraForm
    {
        public ReadMemForm()
        {
            InitializeComponent();
            //connectReader();
            cbWriteTextMemType.SelectedIndex = 0;
            cbWriteTextMemType.Enabled = false;
            tbWriteTextLocation.Enabled = false;
        }
        public ReadMemForm(int selectedNavPane, ConnectType connectType, string address)
        {
            InitializeComponent();
            connectReader(connectType, address);
            cbWriteTextMemType.SelectedIndex = 0;
            cbWriteTextMemType.Enabled = false;
            tbWriteTextLocation.Enabled = false;
            navigationPane1.SelectedPageIndex = selectedNavPane;

        }
        private void connectReader(ConnectType connectType, string addr)
        {
            if (reader != null)
            {//연결해지 처리를 합니다.
                if (reader.IsHandling)//연결되어 있는 지를 확인하고
                {
                    reader.Close(CloseType.Close);//연결을 해지합니다.
                    return;
                }
            }

            //리더를 생성하고 초기화 합니다.
            //리더에서 발생되는 이벤트을 처리하기 위한 핸들러를 추가해 줍니다.
            reader = new Reader();
            reader.ReaderEvent += new ReaderEventHandler(OnReaderEvent);
            reader.ModelType = ModelType;
            reader.ConnectType = connectType;
            reader.TagType = TagType;

            if (connectType == ConnectType.Tcp)
                reader.Open(addr, 5578);
            else
            {
                reader.Open(addr, 115200);
            }
        }
        Reader reader = null;
        string szTID = string.Empty;
        bool isWriteMem = false;
        bool isSaveTag = false;
        bool isSaveTID = false;
        bool isSaveEPC = false;
        bool isSaveUser = false;
        bool isSaveReserved = false;
        #region P/Invoke...
        [DllImport("User32.dll")]
        static extern Boolean MessageBeep(UInt32 beepType);
        #endregion
        public ModelType ModelType
        {
            get
            {
                ModelType modelType = (ModelType)Enum.Parse(typeof(ModelType), "IDRO900F");
                return modelType;
            }
        }
        public TagType TagType
        {
            get
            {
                TagType tagType = (TagType)Enum.Parse(typeof(TagType), "ISO18000_6C_GEN2");
                return tagType;
            }
        }
        private void OnReaderEvent(object sender, ReaderEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new ReaderEventHandler(OnReaderEvent), new object[] { sender, e });
                return;
            }
            
            switch (e.Type)
            {
                case EventType.ReadMemory:
                    {
                        string result = Encoding.ASCII.GetString(e.Payload);
                        if (!isSaveTag)
                        {
                            if (result.Substring(1, result.Length - 1) == "C00")
                            {
                                tbReadResult.Text = "Error code - 00: Fail to read";
                            }
                            else if (result.Substring(1, result.Length - 1) == "T00")
                            {
                                tbReadResult.Text = "Error: Over length";
                            }
                            else
                            {
                                tbReadResult.Text = result.Substring(2, result.Length - 4);
                            }
                            //tbReadResult.Text = result;
                            //if (result[2] == 'E')
                            //    szTID = result;
                        }
                        else if(isSaveTag)
                        {
                            TagInformation tag = new TagInformation();
                            if (isSaveTID)
                            {
                                isSaveTID = false;
                                if (result.Substring(1, result.Length - 1) == "C00")
                                {
                                    lbxRespone.Items.Add("Error code - 00: Fail to read TID memory.");
                                }
                                else if (result.Substring(1, result.Length - 1) == "T00")
                                {
                                    lbxRespone.Items.Add("Error: Over length of TID memory");
                                }
                                else
                                {
                                    lbxRespone.Items.Add("Reading TID memory is success.");
                                    tag.TIDMem  = result.Substring(2, result.Length - 4);
                                }
                            }
                            if (isSaveEPC)
                            {
                                isSaveEPC = false;
                                if (result.Substring(1, result.Length - 1) == "C00")
                                {
                                    lbxRespone.Items.Add("Error code - 00: Fail to read EPC memory.");
                                }
                                else if (result.Substring(1, result.Length - 1) == "T00")
                                {
                                    lbxRespone.Items.Add("Error: Over length of EPC memory");
                                }
                                else
                                {
                                    lbxRespone.Items.Add("Reading EPC memory is success.");
                                    tag.EPCMem = result.Substring(2, result.Length - 4);
                                }
                            }
                            if (isSaveUser)
                            {
                                isSaveUser = false;
                                if (result.Substring(1, result.Length - 1) == "C00")
                                {
                                    lbxRespone.Items.Add("Error code - 00: Fail to read User memory.");
                                }
                                else if (result.Substring(1, result.Length - 1) == "T00")
                                {
                                    lbxRespone.Items.Add("Error: Over length of USer memory");
                                }
                                else
                                {
                                    lbxRespone.Items.Add("Reading User memory is success.");
                                    tag.userMem = result.Substring(2, result.Length - 4);
                                }
                            }
                            if (isSaveReserved)
                            {
                                isSaveReserved = false;
                                if (result.Substring(1, result.Length - 1) == "C00")
                                {
                                    lbxRespone.Items.Add("Error code - 00: Fail to read Reserved memory.");
                                }
                                else if (result.Substring(1, result.Length - 1) == "T00")
                                {
                                    lbxRespone.Items.Add("Error: Over length of Reserved memory");
                                }
                                else
                                {
                                    lbxRespone.Items.Add("Reading Reserved memory is success.");
                                    tag.reservedMem = result.Substring(2, result.Length - 4);
                                }
                            }
                            TagInformationConnUtils connTag = new TagInformationConnUtils();
                            connTag.addTag(tag.TIDMem, tag.EPCMem, tag.userMem, tag.reservedMem);
                            isSaveTag = false;
                        }
                        else if (isWriteMem)
                        {
                            if (result.Substring(1, result.Length - 1) == "C00")
                            {
                                lbReadTID.Text = ("Error code - 00: Fail to read TID memory.");
                            }
                            else if (result.Substring(1, result.Length - 1) == "T00")
                            {
                                lbReadTID.Text = ("Error: Over length of TID memory");
                            }
                            else
                            {
                                lbReadTID.Text = ("Reading TID memory is success.");
                                string TIDmem = result.Substring(2, result.Length - 4);
                                TagInformationConnUtils connTag = new TagInformationConnUtils();
                                bool chkExist = connTag.checkTagExist(TIDmem);
                            }
                        }
                        break;
                    }
                case EventType.WriteMemory:
                    {
                        string result = Encoding.ASCII.GetString(e.Payload);
                        Console.WriteLine(result);
                        switch(navigationPane1.SelectedPageIndex)
                        {
                            case 1:
                                {
                                    if (result.Substring(1, result.Length - 1) == "C01")
                                    {
                                        lbWriteResult.Text = "01 - Success";

                                    }
                                    else
                                    {
                                        lbWriteResult.Text = "00 - Other error";
                                    }
                                        break;
                                }
                            case 2:
                                {
                                    if(result.Substring(1, result.Length - 1) == "C01")
                                    {
                                        lbWriteTextResult.Text ="01 - Success";
                                    }
                                    else
                                    {
                                        lbWriteTextResult.Text = "00 - Other error";
                                    }
                                    break;
                                }
                            default:break;

                        }
                        
                        //string result = Encoding.ASCII.GetString(e.Payload);
                        //lbWriteResult.Text = navigationPane1.SelectedPageIndex == 1 ? result : "";
                        //lbWriteTextResult.Text = navigationPane1.SelectedPageIndex == 2 ? result : "";
                        break;
                        }
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reader.Close(CloseType.Close);
            this.Close();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            switch (navigationPane1.SelectedPageIndex)
            {
                case 0://Read data
                    {
                        string memType = cbReadMemType.Text;
                        uint location = (uint)tbReadLocation.Value;
                        uint length = (uint)tbReadLength.Value;
                        try
                        {
                            if (memType == "EPC")
                                reader.ReadMemory(MemoryType.EPC, location, length);
                            if (memType == "TID")
                                reader.ReadMemory(MemoryType.TID, location, length);
                            if (memType == "User")
                                reader.ReadMemory(MemoryType.User, location, length);
                            if (memType == "Reserved")
                                reader.ReadMemory(MemoryType.Reserved, location, length);
                        }
                        catch
                        {
                            //MessageBox.Show("Error", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbReadResult.Text = "Error";
                        }
                        break;
                    }
                case 1://Write Data
                    {
                        isWriteMem = true;
                        reader.ReadMemory(MemoryType.TID, 0, 12);
                        Task.Delay(100);
                        string memType = cbWriteMemType.Text;
                        uint location = (uint)tbWriteLocation.Value;
                        //uint tbReadLength = (uint)tbWriteLength.Value;
                        string szData = tbWriteData.Text;
                        if (szData == "")
                            MessageBox.Show("Warning", "Data can not be empty!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            bool chk = true;
                            string hex = szData;
                            for (int i = 0; i < szData.Length; i++)
                            {
                                if (szData[i] < '0' || (szData[i] > '9' && szData[i] < 'A') || szData[i] > 'F')
                                {
                                    chk = false;
                                    break;
                                }
                            }
                            if(!chk)
                            {
                                //lbWriteResult.Text = "Input string is not HEX format.";
                                DialogResult dr = MessageBox.Show("This input string is not HEX format. Do you want continue with converting?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    char[] arr = szData.ToCharArray();
                                    StringBuilder sb = new StringBuilder();
                                    foreach (char c in arr)
                                    {
                                        sb.Append(((Int16)c).ToString("x"));
                                    }
                                    hex = string.Empty;
                                    hex = sb.ToString();
                                }
                            }
                            if (memType == "EPC")
                            {
                                reader.WriteMemory(MemoryType.EPC, location, hex);
                            }
                            if (memType == "TID")
                                reader.WriteMemory(MemoryType.TID, location, hex);
                            if (memType == "User")
                                reader.WriteMemory(MemoryType.User, location, hex);
                            if (memType == "Reserved")
                            {
                                DialogResult dr = MessageBox.Show("It's not safe when access Reserved memory. Do you want continue?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                                if (dr == DialogResult.Yes)
                                    reader.WriteMemory(MemoryType.Reserved, location, hex);
                                else return;
                            }
                        }
                        break;
                    }
                case 2://Write TEXT
                    {
                        string szData = tbWriteTextData.Text;
                        //CipherAlgorithm ca = new CipherAlgorithm();
                        //string key = ca.randomKeyCode();
                        //string szCipher = ca.Encrypt(szData, key);
                        //Console.WriteLine(szCipher);
                        //reader.WriteMemory(szCipher);
                        ////reader.ReadMemory(MemoryType.TID, 0, 12);
                        //string sql = "INSERT INTO cryptography.keycode(code, time_generate, TID) VALUE('" + key + "', '" + DateTime.Now + "', '" + szTID + "')";
                        //cmd = new MySqlCommand(sql, con);
                        //MySqlDataReader my_reader;
                        //try
                        //{
                        //    OpenConnection();
                        //    my_reader = cmd.ExecuteReader();
                        //    CloseConnection();
                        //}
                        //catch (MySqlException ex)
                        //{
                        //    MessageBox.Show("Cannot Excute Command: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    CloseConnection();
                        //}
                        reader.WriteMemory(szData);
                        break;
                    }
                case 3://Save Tag
                    {
                        isSaveTag = true;
                        isSaveTID = true;
                        reader.ReadMemory(MemoryType.TID, 0, (uint)tbTIDLength.Value);
                        Task.Delay(100);
                        isSaveEPC = true;
                        reader.ReadMemory(MemoryType.EPC, 0, (uint)tbEPCLength.Value);
                        Task.Delay(100);
                        isSaveUser = true;
                        reader.ReadMemory(MemoryType.User, 0, (uint)tbUserLength.Value);
                        Task.Delay(100);
                        isSaveReserved = true;
                        reader.ReadMemory(MemoryType.Reserved, 0, (uint)tbReservedLength.Value);
                        Task.Delay(100);
                        break;
                    }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbReadResult.Text = "...";
            lbWriteResult.Text = "...";
            lbWriteTextResult.Text = "...";
            lbxRespone.Controls.Clear();
        }
    }
}

