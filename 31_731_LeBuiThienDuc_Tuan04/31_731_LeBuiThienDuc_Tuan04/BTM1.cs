using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_731_LeBuiThienDuc_Tuan04
{
    public partial class BTM1 : Form
    {
        public BTM1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lstPhai.Items.Add(lstTrai.SelectedItem.ToString());
                lstTrai.Items.Remove(lstTrai.SelectedItem.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khong Ton Tai de xoa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lstTrai.Items.Add(lstPhai.SelectedItem.ToString());
                lstPhai.Items.Remove(lstPhai.SelectedItem.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khong Ton Tai De Chuyen");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lstPhai.Items.AddRange(lstTrai.Items);
                lstTrai.Items.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khong Chuyen Duoc");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                lstTrai.Items.AddRange(lstPhai.Items);
                lstPhai.Items.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khong Ton Tai de chuyen");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> listtemp = new List<string>();
         foreach(var item in lstTrai.SelectedItems)
         {
             lstPhai.Items.Add(item);
             listtemp.Add(item.ToString());
         }
            foreach(var item in listtemp)
            {

                if(lstTrai.Items.Contains(item))
                {
                    lstTrai.Items.Remove(item);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> listtemp = new List<string>();
            foreach (var item in lstPhai.SelectedItems)
            {
                lstTrai.Items.Add(item);
                listtemp.Add(item.ToString());
            }
            foreach (var item in listtemp)
            {

                if (lstPhai.Items.Contains(item))
                {
                    lstPhai.Items.Remove(item);
                }
            }
        }

        private void BTM1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
