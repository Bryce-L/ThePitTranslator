namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputRichTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.outputTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(632, 458);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(632, 276);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "HIUVHEHAARRR HMAUMRRRSH HMOWOI RRRAAQROREHRRRAA OWKHKHNGEHPROWWREHAUNHSH AUF WRMO" +
    "KHAU THAUWRDERORNH THAANGNGSH, KHRORNHKH PRNGOWMOKH, OWNHHM OW DEEHOWNHWR HMEHWR" +
    "AUKHAUNHHMRRREHOW.";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(0, 0);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(632, 178);
            this.outputTextBox.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(284, 476);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.goButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 511);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button goButton;
    }
}

