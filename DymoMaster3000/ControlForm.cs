using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DymoMaster3000
{
    public partial class DymoMaster300 : Form
    {
        public DymoMaster300()
        {
            InitializeComponent();

            dymoItemList.Items.Add("test");
            dymoItemList.Items.Add("test");
            dymoItemList.Items.Add("test");
            dymoItemList.Items.Add("test");
        }

        private void dymoEditor_TextChanged(object sender, EventArgs e)
        {
            if (dymoEditor.Enabled == false || dymoItemList.SelectedIndex == -1)
            {
                return;
            }

            dymoItemList.Items[dymoItemList.SelectedIndex] = dymoEditor.Text;
            dymoItemList.Update();
        }

        private void dymoItemList_Click(object sender, EventArgs e)
        {
            if (dymoItemList.SelectedIndex != -1)
            {
                dymoEditor.Enabled = true;
                dymoEditor.Text = (String)dymoItemList.Items[dymoItemList.SelectedIndex];
                dymoEditor.Focus();
            }
            else
            {
                dymoEditor.Text = "";
                dymoEditor.Enabled = false;
            }
        }
    }
}
