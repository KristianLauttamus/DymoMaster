namespace DymoMaster3000
{
    partial class DymoMaster300
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DymoMaster300));
            this.convertToDymo = new System.Windows.Forms.Button();
            this.trimWhiteSpace = new System.Windows.Forms.CheckBox();
            this.delimiter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parseField = new System.Windows.Forms.TextBox();
            this.dymoItemList = new System.Windows.Forms.ListBox();
            this.dymoEditor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dymoSecondEditor = new System.Windows.Forms.TextBox();
            this.InsertSecondRowsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.updateItem = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.dymoStickerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dymoStickerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // convertToDymo
            // 
            this.convertToDymo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.convertToDymo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertToDymo.Location = new System.Drawing.Point(278, 199);
            this.convertToDymo.Name = "convertToDymo";
            this.convertToDymo.Size = new System.Drawing.Size(172, 23);
            this.convertToDymo.TabIndex = 3;
            this.convertToDymo.Text = "Convert to Dymo >>";
            this.convertToDymo.UseVisualStyleBackColor = false;
            this.convertToDymo.Click += new System.EventHandler(this.convertToDymo_Click);
            // 
            // trimWhiteSpace
            // 
            this.trimWhiteSpace.AutoSize = true;
            this.trimWhiteSpace.Checked = true;
            this.trimWhiteSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trimWhiteSpace.Location = new System.Drawing.Point(312, 176);
            this.trimWhiteSpace.Name = "trimWhiteSpace";
            this.trimWhiteSpace.Size = new System.Drawing.Size(103, 17);
            this.trimWhiteSpace.TabIndex = 2;
            this.trimWhiteSpace.Text = "Trim whitespace";
            this.trimWhiteSpace.UseVisualStyleBackColor = true;
            // 
            // delimiter
            // 
            this.delimiter.Location = new System.Drawing.Point(312, 149);
            this.delimiter.Name = "delimiter";
            this.delimiter.Size = new System.Drawing.Size(103, 20);
            this.delimiter.TabIndex = 1;
            this.delimiter.Text = ",";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Splitter";
            // 
            // parseField
            // 
            this.parseField.AcceptsReturn = true;
            this.parseField.AcceptsTab = true;
            this.parseField.Location = new System.Drawing.Point(13, 39);
            this.parseField.Multiline = true;
            this.parseField.Name = "parseField";
            this.parseField.Size = new System.Drawing.Size(259, 360);
            this.parseField.TabIndex = 0;
            // 
            // dymoItemList
            // 
            this.dymoItemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dymoItemList.FormattingEnabled = true;
            this.dymoItemList.Location = new System.Drawing.Point(456, 65);
            this.dymoItemList.Name = "dymoItemList";
            this.dymoItemList.Size = new System.Drawing.Size(285, 301);
            this.dymoItemList.TabIndex = 100;
            this.dymoItemList.Click += new System.EventHandler(this.dymoItemList_Click);
            // 
            // dymoEditor
            // 
            this.dymoEditor.Enabled = false;
            this.dymoEditor.Location = new System.Drawing.Point(456, 39);
            this.dymoEditor.Name = "dymoEditor";
            this.dymoEditor.Size = new System.Drawing.Size(103, 20);
            this.dymoEditor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Edit selected";
            // 
            // dymoSecondEditor
            // 
            this.dymoSecondEditor.Enabled = false;
            this.dymoSecondEditor.Location = new System.Drawing.Point(565, 39);
            this.dymoSecondEditor.Name = "dymoSecondEditor";
            this.dymoSecondEditor.Size = new System.Drawing.Size(98, 20);
            this.dymoSecondEditor.TabIndex = 6;
            // 
            // InsertSecondRowsButton
            // 
            this.InsertSecondRowsButton.Location = new System.Drawing.Point(459, 372);
            this.InsertSecondRowsButton.Name = "InsertSecondRowsButton";
            this.InsertSecondRowsButton.Size = new System.Drawing.Size(282, 23);
            this.InsertSecondRowsButton.TabIndex = 4;
            this.InsertSecondRowsButton.Text = "Insert second rows >>";
            this.InsertSecondRowsButton.UseVisualStyleBackColor = true;
            this.InsertSecondRowsButton.Click += new System.EventHandler(this.InsertSecondRowsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Parsefield";
            // 
            // updateItem
            // 
            this.updateItem.Location = new System.Drawing.Point(669, 39);
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(72, 23);
            this.updateItem.TabIndex = 7;
            this.updateItem.Text = "UPDATE";
            this.updateItem.UseVisualStyleBackColor = true;
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(307, 372);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 23);
            this.saveButton.TabIndex = 101;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(278, 372);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(23, 23);
            this.infoButton.TabIndex = 102;
            this.infoButton.Text = "?";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // dymoStickerBindingSource
            // 
            this.dymoStickerBindingSource.DataSource = typeof(DymoMaster3000.DymoSticker);
            // 
            // DymoMaster300
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 411);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsertSecondRowsButton);
            this.Controls.Add(this.dymoSecondEditor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dymoEditor);
            this.Controls.Add(this.dymoItemList);
            this.Controls.Add(this.parseField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delimiter);
            this.Controls.Add(this.trimWhiteSpace);
            this.Controls.Add(this.convertToDymo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DymoMaster300";
            this.Text = "DymoMaster 3000";
            ((System.ComponentModel.ISupportInitialize)(this.dymoStickerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertToDymo;
        private System.Windows.Forms.CheckBox trimWhiteSpace;
        private System.Windows.Forms.TextBox delimiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parseField;
        private System.Windows.Forms.ListBox dymoItemList;
        private System.Windows.Forms.TextBox dymoEditor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dymoSecondEditor;
        private System.Windows.Forms.Button InsertSecondRowsButton;
        private System.Windows.Forms.BindingSource dymoStickerBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button infoButton;
    }
}

