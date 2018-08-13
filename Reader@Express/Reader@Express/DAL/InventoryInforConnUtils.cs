using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;
using Reader_Express.OBJECT;

namespace Reader_Express.DAL
{
    class InventoryInforConnUtils
    {
        public void add(string tagID, string text, int rssi, DateTime time_stamp, int antenna_number)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string sql = "Insert into cryptography.inventory_infor(tagID, text, RSSI, time_stamp, antenna_number) values('"
                + tagID + "', '"
                + text + "', '"
                + rssi + "', '"
                + time_stamp + "', '"
                + antenna_number + "');";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Add error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<InventoryInfor> getListByTagId(string tagId)
        {
            List<InventoryInfor> invInfors = new List<InventoryInfor>();
            InventoryInfor invInfor = new InventoryInfor();
            MySqlConnection conn = DBUtils.GetDBConnection();
            string sql = "select tagID, text, RSSI, time_stamp, antenna_number from cryptography.inventory_infor where tagID = '" + tagId + "';";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            invInfor.tagID = reader.GetString(0);
                            invInfor.text = reader.GetString(1);
                            invInfor.rssi = reader.GetInt32(2);
                            invInfor.time_stamp = (DateTime)reader.GetDateTime(3);
                            invInfor.antenna_number = reader.GetInt32(4);
                            invInfors.Add(invInfor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Get Inventory Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return invInfors;
        }

        public int countNumOfReadByTagId(string tagID)
        {
            int count = 0;
            MySqlConnection conn = DBUtils.GetDBConnection();
            string sql = "select count(*) from cryptography.inventory_infor where tagID = '" + tagID + "';";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            count = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return count;
        }
    }
}
