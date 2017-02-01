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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parseField = new System.Windows.Forms.TextBox();
            this.dymoItemList = new System.Windows.Forms.ListBox();
            this.dymoEditor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert to Dymo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(278, 176);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Trim whitespace";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jakaja";
            // 
            // parseField
            // 
            this.parseField.AcceptsReturn = true;
            this.parseField.AcceptsTab = true;
            this.parseField.Location = new System.Drawing.Point(13, 13);
            this.parseField.Multiline = true;
            this.parseField.Name = "parseField";
            this.parseField.Size = new System.Drawing.Size(259, 386);
            this.parseField.TabIndex = 5;
            // 
            // dymoItemList
            // 
            this.dymoItemList.FormattingEnabled = true;
            this.dymoItemList.Location = new System.Drawing.Point(456, 65);
            this.dymoItemList.Name = "dymoItemList";
            this.dymoItemList.Size = new System.Drawing.Size(285, 329);
            this.dymoItemList.TabIndex = 6;
            this.dymoItemList.Click += new System.EventHandler(this.dymoItemList_Click);
            // 
            // dymoEditor
            // 
            this.dymoEditor.Enabled = false;
            this.dymoEditor.Location = new System.Drawing.Point(456, 39);
            this.dymoEditor.Name = "dymoEditor";
            this.dymoEditor.Size = new System.Drawing.Size(285, 20);
            this.dymoEditor.TabIndex = 7;
            this.dymoEditor.TextChanged += new System.EventHandler(this.dymoEditor_TextChanged);
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
            // DymoMaster300
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dymoEditor);
            this.Controls.Add(this.dymoItemList);
            this.Controls.Add(this.parseField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Name = "DymoMaster300";
            this.Text = "DymoMaster 3000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parseField;
        private System.Windows.Forms.ListBox dymoItemList;
        private System.Windows.Forms.TextBox dymoEditor;
        private System.Windows.Forms.Label label2;
    }
}

