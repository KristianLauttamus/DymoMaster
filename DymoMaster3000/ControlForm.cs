using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DymoMaster3000
{
    public partial class DymoMaster300 : Form
    {
        private SerialGiver secondRowGiver;

        public DymoMaster300()
        {
            InitializeComponent();

            this.InsertSecondRowsButton.Enabled = false;
            this.updateItem.Enabled = false;
            this.saveButton.Enabled = false;
            secondRowGiver = new SerialGiver(new DymoSticker[0], this.trimWhiteSpace.Checked);
        }

        private void updateList()
        {
            DymoSticker[] items = new DymoSticker[this.dymoItemList.Items.Count];
            this.dymoItemList.Items.CopyTo(items, 0);
            
            List<DymoSticker> stickers = new List<DymoSticker>();
            this.dymoItemList.Items.Clear();

            for (int i = 0; i < items.Length; i++)
            {
                DymoSticker sticker = (DymoSticker)items[i];

                if (sticker.isEmpty() == false)
                {
                    stickers.Add(sticker);
                }
            }

            if (stickers.Count > 0)
            {
                this.InsertSecondRowsButton.Enabled = true;
                this.saveButton.Enabled = true;
            }
            else
            {
                this.InsertSecondRowsButton.Enabled = false;
                this.saveButton.Enabled = false;
            }

            this.dymoItemList.Items.AddRange(stickers.ToArray());
        }

        private void dymoItemList_Click(object sender, EventArgs e)
        {
            if (dymoItemList.SelectedIndex != -1)
            {
                dymoEditor.Enabled = true;
                dymoEditor.Text = ((DymoSticker)dymoItemList.Items[dymoItemList.SelectedIndex]).firstLine;
                dymoSecondEditor.Enabled = true;
                dymoSecondEditor.Text = ((DymoSticker)dymoItemList.Items[dymoItemList.SelectedIndex]).secondLine;
                dymoEditor.Focus();
                updateItem.Enabled = true;
            }
            else
            {
                dymoEditor.Text = "";
                dymoEditor.Enabled = false;
                dymoSecondEditor.Text = "";
                dymoSecondEditor.Enabled = false;
                updateItem.Enabled = false;
            }
        }

        private void InsertSecondRowsButton_Click(object sender, EventArgs e)
        {
            DymoSticker[] stickers = new DymoSticker[this.dymoItemList.Items.Count];
            this.dymoItemList.Items.CopyTo(stickers, 0);
            this.secondRowGiver = new SerialGiver(stickers, this.trimWhiteSpace.Checked);
            this.secondRowGiver.FormClosing += new FormClosingEventHandler(SerialGiver_Closing);
            this.secondRowGiver.Show();
            this.secondRowGiver.loadCurrent();
        }

        private void SerialGiver_Closing(object sender, FormClosingEventArgs e)
        {
            this.dymoItemList.Items.Clear();
            this.dymoItemList.Items.AddRange(this.secondRowGiver.items);
            this.updateList();
        }

        private void convertToDymo_Click(object sender, EventArgs e)
        {
            this.dymoItemList.Items.Clear();

            using (StringReader reader = new StringReader(this.parseField.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Trim() != "")
                    {
                        string[] items;
                        if (this.delimiter.Text != "")
                        {
                            items = line.Split(new string[] { this.delimiter.Text }, StringSplitOptions.None);
                        }
                        else
                        {
                            items = new string[] { line };
                        }

                        foreach (string item in items)
                        {
                            string firstRow = item;
                            if (this.trimWhiteSpace.Checked)
                            {
                                firstRow = firstRow.Trim();
                            }

                            this.dymoItemList.Items.Add(new DymoSticker(firstRow));
                        }
                    }
                }
            }

            updateList();
        }

        private void updateItem_Click(object sender, EventArgs e)
        {
            if (dymoEditor.Enabled == false || dymoItemList.SelectedIndex == -1)
            {
                return;
            }
            
            if (dymoSecondEditor.Enabled == false || dymoItemList.SelectedIndex == -1)
            {
                return;
            }

            ((DymoSticker)dymoItemList.Items[dymoItemList.SelectedIndex]).firstLine = dymoEditor.Text;
            ((DymoSticker)dymoItemList.Items[dymoItemList.SelectedIndex]).secondLine = dymoSecondEditor.Text;
            this.dymoItemList.SelectedIndex = -1;
            updateList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save The Magical Dymofile";
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.FileName = "DymoMagic";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "csv";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    System.IO.FileStream fs = (System.IO.FileStream)stream;

                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        for (int i = 0; i < dymoItemList.Items.Count; i++) {
                            sw.WriteLine(((DymoSticker)dymoItemList.Items[i]).toDymo());
                        }
                    }

                    stream.Close();
                }
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }
    }
}
