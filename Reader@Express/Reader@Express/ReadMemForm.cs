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

namespace Reader_Express
{
    public partial class ReadMemForm : Form
    {
        public ReadMemForm()
        {
            InitializeComponent();
            connectTCP();
            cbWriteTextMemType.SelectedIndex = 0;
            cbWriteTextMemType.Enabled = false;
            tbWriteTextLocation.Enabled = false;
        }
        public ReadMemForm(int selectedNavPane)
        {
            InitializeComponent();
            connectTCP();
            cbWriteTextMemType.SelectedIndex = 0;
            cbWriteTextMemType.Enabled = false;
            tbWriteTextLocation.Enabled = false;
            navigationPane1.SelectedPageIndex = selectedNavPane;

        }
        private void connectTCP()
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
            reader.ConnectType = ConnectType;
            reader.TagType = TagType;

            if (ConnectType == ConnectType.Tcp)
                reader.Open("192.168.0.190", 5578);
            else
            {
                //reader.Open(cbxSerialPort.Text, 115200);
            }
        }
        Reader reader = null;
        string szTID = string.Empty;
        static String connString = "Server=localhost;Database=cryptography;Port=3306;User ID=root;Password=1969626298";
        MySqlConnection con = new MySqlConnection(connString);
        MySqlCommand cmd;
        public void OpenConnection()
        {
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cannot Connected Server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cannot Close Connect: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
        public ConnectType ConnectType
        {
            get
            {
                ConnectType connectType = ConnectType.Tcp;
                return connectType;
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
                        break;
                    }
                case EventType.WriteMemory:
                    {
                        string result = Encoding.ASCII.GetString(e.Payload);
                        lbWriteResult.Text = navigationPane1.SelectedPageIndex == 1 && result.Substring(1, result.Length - 1) == "C01" ? "01 - Success" : "00 - Other error";
                        lbWriteTextResult.Text = navigationPane1.SelectedPageIndex == 2 && result.Substring(1, result.Length - 1) == "C01" ? "01 - Success" : "00 - Other error";
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
                        string memType = cbWriteMemType.Text;
                        uint location = (uint)tbWriteLocation.Value;
                        //uint tbReadLength = (uint)tbWriteLength.Value;
                        string szData = tbWriteData.Text;
                        if (szData == "")
                            MessageBox.Show("Warning", "Data can not be empty!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            if (memType == "EPC")
                            {
                                reader.WriteMemory(MemoryType.EPC, location, szData);
                            }
                            if (memType == "TID")
                                reader.WriteMemory(MemoryType.TID, location, szData);
                            if (memType == "User")
                                reader.WriteMemory(MemoryType.User, location, szData);
                            if (memType == "Reserved")
                                reader.WriteMemory(MemoryType.Reserved, location, szData);
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EncryptForm ef = new EncryptForm();
            //ef.ShowDialog();
            tbReadResult.Text = "";
        }
    }
}
