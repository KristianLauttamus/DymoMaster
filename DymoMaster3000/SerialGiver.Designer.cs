namespace DymoMaster3000
{
    partial class SerialGiver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialGiver));
            this.label1 = new System.Windows.Forms.Label();
            this.firstRow = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            this.secondRow = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.prevInspector = new System.Windows.Forms.Label();
            this.prevFirst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert second row for:";
            // 
            // firstRow
            // 
            this.firstRow.AutoSize = true;
            this.firstRow.Location = new System.Drawing.Point(150, 12);
            this.firstRow.Name = "firstRow";
            this.firstRow.Size = new System.Drawing.Size(24, 13);
            this.firstRow.TabIndex = 1;
            this.firstRow.Text = "test";
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(16, 30);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(44, 23);
            this.previous.TabIndex = 2;
            this.previous.Text = "<<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // secondRow
            // 
            this.secondRow.Location = new System.Drawing.Point(66, 33);
            this.secondRow.Name = "secondRow";
            this.secondRow.Size = new System.Drawing.Size(174, 20);
            this.secondRow.TabIndex = 3;
            this.secondRow.KeyUp += new System.Windows.Forms.KeyEventHandler(this.secondRow_KeyUp);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(246, 31);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(44, 23);
            this.next.TabIndex = 5;
            this.next.Text = ">>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prevInspector
            // 
            this.prevInspector.AutoSize = true;
            this.prevInspector.Location = new System.Drawing.Point(82, 64);
            this.prevInspector.Name = "prevInspector";
            this.prevInspector.Size = new System.Drawing.Size(24, 13);
            this.prevInspector.TabIndex = 8;
            this.prevInspector.Text = "test";
            // 
            // prevFirst
            // 
            this.prevFirst.AutoSize = true;
            this.prevFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevFirst.Location = new System.Drawing.Point(13, 64);
            this.prevFirst.Name = "prevFirst";
            this.prevFirst.Size = new System.Drawing.Size(60, 13);
            this.prevFirst.TabIndex = 7;
            this.prevFirst.Text = "Previous:";
            // 
            // SerialGiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 86);
            this.Controls.Add(this.prevInspector);
            this.Controls.Add(this.prevFirst);
            this.Controls.Add(this.next);
            this.Controls.Add(this.secondRow);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.firstRow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialGiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecondRowGiver";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstRow;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.TextBox secondRow;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label prevInspector;
        private System.Windows.Forms.Label prevFirst;
    }
}