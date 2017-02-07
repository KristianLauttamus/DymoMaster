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
    public partial class SerialGiver : Form
    {
        public DymoSticker[] items;
        private int index;
        private bool trimWhiteSpace;

        public SerialGiver(DymoSticker[] items, bool trimWhiteSpace)
        {
            this.items = items;
            this.index = 0;
            this.trimWhiteSpace = trimWhiteSpace;

            this.InitializeComponent();
            this.prevInspector.Text = "";
            this.firstRow.Text = "";

            if (this.items.Length > 0)
            {
                this.loadCurrent();
            }
            else
            {
                this.secondRow.Enabled = false;
                this.next.Enabled = false;
                this.previous.Enabled = false;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            nextRows();
        }

        public void loadCurrent()
        {
            this.firstRow.Text = ((DymoSticker)this.items[index]).firstLine;
            this.secondRow.Text = ((DymoSticker)this.items[index]).secondLine;

            if (this.firstRow.Text.Length > 0)
            {
                this.secondRow.Enabled = true;
            }

            if (index == 0)
            {
                this.previous.Enabled = false;
            }
            else
            {
                this.previous.Enabled = true;
            }

            if (index == this.items.Length-1)
            {
                this.next.Enabled = false;
            }
            else
            {
                this.next.Enabled = true;
            }
        }

        private void saveCurrent()
        {
            ((DymoSticker)this.items[index]).secondLine = this.secondRow.Text;

            if (this.trimWhiteSpace)
            {
                ((DymoSticker)this.items[index]).secondLine.Trim();
            }
        }

        private void previousRows()
        {
            this.saveCurrent();

            if (index > 0)
            {
                index--;
                this.prevInspector.Text = "";
            }

            loadCurrent();
            this.secondRow.Focus();
        }

        private void nextRows()
        {
            this.saveCurrent();

            if (index < this.items.Length-1)
            {
                this.prevInspector.Text = ((DymoSticker)this.items[index]).firstLine + ";" + ((DymoSticker)this.items[index]).secondLine;
                index++;
            }

            loadCurrent();
            this.secondRow.Focus();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            this.previousRows();
        }

        private void secondRow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool close = false;
                if (this.index == this.items.Length-1)
                {
                    close = true;
                }

                this.nextRows();

                if (close)
                    this.Close();
            }
        }
    }
}
