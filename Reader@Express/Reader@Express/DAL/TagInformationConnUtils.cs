using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Common;

namespace Reader_Express.DAL
{
    class TagInformationConnUtils
    {
        public void addTag(string TIDMem, string EPCMem, string userMem, string reservedMem)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            string sql = "insert into cryptography.tag_information(TID_mem, EPC_mem, user_mem, reserved_mem, time_stamp) values('"
                + TIDMem + "', '"
                + EPCMem + "', '"
                + userMem + "', '"
                + reservedMem + "', '"
                + DateTime.Now + "');";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Add tag error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        public bool checkTagExist(string TIDmem)
        {
            bool chkExist = false;
            MySqlConnection conn = DBUtils.GetDBConnection();
            string sql = "select * from cryptography.tag_information where TID_mem = '" + TIDmem + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                        chkExist = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Check exist error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return chkExist;
        }
    }
}
