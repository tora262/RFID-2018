using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Reader_Express.OBJECT;
using Reader_Express.DAL;

namespace Reader_Express
{
    public partial class ShowInventory : DevExpress.XtraEditors.XtraForm
    {
        public ShowInventory()
        {
            InitializeComponent();
        }

        public ShowInventory(string tagID)
        {
            InitializeComponent();
            initData(tagID);
        }

        private void initData(string tagID)
        {
            string[] header = { "Tag ID", "TEXT", "RSSI", "Time Stamp", "Ant No." };
            InventoryInforConnUtils connInven = new InventoryInforConnUtils();
            List<InventoryInfor> invInforList = connInven.getListByTagId(tagID);
            gridControlInventory.DataSource = invInforList;
            for (int i = 0; i < header.Length; i++)
            {
                gridViewInventory.Columns[i].Caption = header[i];
            }

        }
    }
}