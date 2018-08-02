using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace Reader_Express
{
    public partial class Map : Form
    {
        bool canPain, flag, flag1;
        Graphics g;
        
        public int[] flag2 = new int[1];
        public static int boxNum = 0, preBox = 0;
        public static List<int> arrbox= new List<int>();
        public int box;
        int x, y; 
        
        int width, height;
        private const int DISROW = 60;
        private const int DISCOL = 60;
        private const int START= 60;
        private static Int32 roomWidth, roomHeight, roomDeep, ratio;
        static System.Windows.Forms.Timer updateMap = new System.Windows.Forms.Timer();
        Pen redPen = new Pen(Color.YellowGreen, 2);
        public Map()
        {
            
            InitializeComponent();
            g = panelMap.CreateGraphics();
            width = panelMap.Width;
            height = panelMap.Height;
            canPain = false;
            flag = false;
            flag1 = false;
            updateMap.Tick += new EventHandler(timerEventProcessor);
            updateMap.Interval = 5000;
        }

        private void Panel_MoveDown(object sender, MouseEventArgs e)
        {
            canPain = true;
            x = e.X;
            y = e.Y;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (chbRaw.Checked)
                flag = true;
            else
                flag = false;

            if (flag == true)
            {
                if (canPain)
                {
                    g.DrawLine(Pens.YellowGreen, x, y, e.X, e.Y);
                    x = e.X;
                    y = e.Y;
                }
            }
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            canPain = false;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            panelMap.Refresh();
            panelMap.Refresh();
            for (int i = 0; i <= 270; i = i + roomWidth)
            {
                g.DrawLine(redPen, i, 0, i, 270);
            }
            for (int i = 0; i <= 270; i = i + roomHeight)
            {
                g.DrawLine(redPen, 0, i, 270, i);
            }
            for (int i = 0; i < arrbox.Count; i++)
            {
                drawBox(arrbox[i]);
            }

        }
        public void getBox(int box)
        {
            if (box != 0)
            {
                boxNum = box;
            }
        }
        
        private void timerEventProcessor(object obj, EventArgs args)
        {
            
            if (preBox != boxNum && preBox != 0)
            {
                deleteLocate(preBox);
            }
            preBox = boxNum;
            updateMap.Stop();
            drawBox(boxNum);
            label6.Text = boxNum.ToString();
            updateMap.Start();
        }
        public void getData(string st1, string st2, string st3, string st4)
        {
            if ((st3 =="") && (st4 == ""))
            {
                roomWidth = Int32.Parse(st1);
                roomHeight = Int32.Parse(st2);
                //ratio = Int32.Parse(st4);
            }
            else
            {
                roomWidth = Int32.Parse(st1);
                roomHeight = Int32.Parse(st2);
                roomDeep = Int32.Parse(st3);
                ratio = Int32.Parse(st4);
            }
        }
        
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                panelMap.Refresh();
                for (int i = 0; i <= 180; i = i + roomWidth)
                {
                    g.DrawLine(redPen, i, 0, i, 180);
                }
                for (int i = 0; i <= 180; i = i + roomHeight)
                {
                    g.DrawLine(redPen, 0, i, 180, i);
                }
                //Font drawFont = new Font("Arial", 16);
                //SolidBrush drawBrush = new SolidBrush(Color.Black);
                //// Create point for upper-left corner of drawing.
                //PointF drawPoint = new PointF(10, 10);
                //g.DrawString("1", drawFont, drawBrush, drawPoint);
                flag1 = false;

                //test
                //string path = Directory.GetCurrentDirectory() + "\\nuclear1.gif";
                //Image img = Image.FromFile(path);
                //Item item = new Item(2 * START, 2 * START, img);
                //item.drawImageItem(g);
               
            }
            else
            {
                MessageBox.Show("Please, run setting","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          //  MessageBox.Show(box.ToString());
        }
        
        private void drawBox(int i)
        {
            if (i == 0) { } //MessageBox.Show("Error:Not found tag");
            else
            {
                i = 10 - i;
                string path = Directory.GetCurrentDirectory();
                path += "\\nuclear1.gif";
                Image img = Image.FromFile(path);
                Item item = new Item(((i - 1) % 3) * START, ((i - 1) / 3) * START, img);
                item.drawImageItem(g);
            }
        }

        //function remove old locate
        private void deleteLocate(int i)
        {
            i = 10 - i;
            string path = Directory.GetCurrentDirectory()+"\\nuclear2.bmp";
            Image img = Image.FromFile(path);
            Item item = new Item(((i - 1) % 3) * START, ((i - 1) / 3) * START, img);
            item.drawImageItem(g);
        }

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            //panelMap.Refresh();
            //for (int i = 0; i <= 270; i = i + roomWidth)
            //{
            //    g.DrawLine(redPen, i, 0, i, 270);
            //}
            //for (int i = 0; i <= 270; i = i + roomHeight)
            //{
            //    g.DrawLine(redPen, 0, i, 270, i);
            //}
           
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            RoomParameter romParamaeter = new RoomParameter();
            romParamaeter.ShowDialog();
            updateMap.Start();
            flag1 = true;      
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            updateMap.Stop();
            drawBox(0);
            //drawBox(sdk.convert_num(0,2));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            updateMap.Start();
            
            //Thread.Sleep(5000);
        }

        private void panelMap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }   
    }
}
