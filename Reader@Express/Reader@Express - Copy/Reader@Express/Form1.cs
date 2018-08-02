﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reader_Express
{
    public partial class Test : Form
    {
       
        double[,] data1 = new double[7,6];
        double[,] data2 = new double[7,6];
        double[,] data3 = new double[7,6];
        double[,] data4 = new double[7,6];
        
        public int real(double a) 
        {
            int k = 0;
            double min = a;
            for (; k <= a; k++)
            {
                double sub = a - k;
                min = (sub < min) ? sub : min;
            }
            return k-1;
        }
        public double Interpol(double[,] mat, double a, double b)
        {
            int a0, b0, a1, b1;
            if (a == 5)
            {
                a0 = 4;
                a1 = 5;
                b0 = real(b);
                b1 = b0 + 1;
            }
            else
            {
                if (b == 6)
                {
                    a0 = real(a);
                    a1 = a0 + 1;
                    b0 = 5;
                    b1 = 6;
                }
                else
                {
                    a0 = real(a);
                    a1 = a0 + 1;
                    b0 = real(b);
                    b1 = b0 + 1;
                }
            }
            double res = mat[a0, b0] * (b1 - b) * (a - a0);
             //double res = mat[a0, b0] * (b1 - b) * (a - a0) + mat[a1, b0] * (b - b0) * (a - a0) + mat[a0, b1] * (b1 - b) * (a1 - a) + mat[a1, b1] * (b - b0) * (a1 - a);
            return res;
        }
        public int convert_num(double x, double y)
        {
            int num = 0;
            int k = 0;
            x = real(x);
            y = real(y);
            if(x == 6) x = 5;
            if(y == 5) y = 4;
            for(int n = 0;n != y; n++)
            {
                for(;k!=x;k++)
                    num = num +1;
                k = 0;
            }
            return num;
            }
        public int[] local_xy(double[,] mt,double z)
        {
            int[] local = new int[30]; 
            int l = 0;
             double inter;
          
            for(int k=0;k<(5/0.2);k++)
                for (int n = 0; n <= (6 / 0.2); n++)
                {
                    inter = Interpol(mt, 0.2 * k, 0.2 * n);
                    if (Math.Abs(z - inter) < 10)
                        local[l++] = convert_num(0.2 * k, 0.2 * n);
                }
            
            return local;
        }
        
        
        public Test()
        {
            InitializeComponent();
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            string cs = @"server=localhost;userid=root;
            password=;database=rfidreader";

            MySqlConnection conn = null;
            MySqlDataReader rdr = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                string stm = "SELECT * FROM training";
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                  /* Console.WriteLine(rdr.GetInt32(0) + ": "
                        + rdr.GetString(1));
                    MessageBox.Show(rdr.GetDouble(3) + ": "
                        + rdr.GetString(4) + ":" + rdr.GetString(5));
                    */
                   data1[i,j] = rdr.GetDouble(2);
                    data2[i,j] = rdr.GetDouble(3);
                    data3[i,j] = rdr.GetDouble(4);
                    data4[i,j++] =rdr.GetDouble(5);
                    if (j == 6) 
                    {
                        i++;
                        j = 0;
                    }
                 }

                MessageBox.Show("Data saved" + ":" + data1[1,0].ToString());
            }
            catch (MySqlException ex)
            {
              //  Console.WriteLine("Error: {0}", ex.ToString());
                MessageBox.Show("Error:" + ex.ToString());
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            double rssx1 = double.Parse(textBox1.Text);
            double rssx2 = double.Parse(textBox2.Text);
            double rssx3 = double.Parse(textBox3.Text);
            double rssx4 = double.Parse(textBox4.Text);
            while (k<10)
            {
                listView1.Items.Insert(0, local_xy(data1, rssx1)[k].ToString());
                listView2.Items.Insert(0, local_xy(data2, rssx2)[k].ToString());
                listView3.Items.Insert(0, local_xy(data3, rssx3)[k].ToString());
                listView4.Items.Insert(0, local_xy(data4, rssx4)[k++].ToString());
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

