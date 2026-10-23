namespace URL_Shortener
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeading = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnShorten = new Button();
            txtURL = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tabPage2 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            btnReturn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox1 = new TextBox();
            btnCopy = new Button();
            label2 = new Label();
            label4 = new Label();
            linkLabelLong = new LinkLabel();
            tabPage3 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            possibleErrorList = new Label();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(0, 5);
            lblHeading.Margin = new Padding(0, 5, 5, 5);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(473, 45);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Paste the URL to be shortened";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(btnShorten, 1, 0);
            tableLayoutPanel1.Controls.Add(txtURL, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 130);
            tableLayoutPanel1.Margin = new Padding(0, 50, 0, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(514, 52);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnShorten
            // 
            btnShorten.Dock = DockStyle.Fill;
            btnShorten.Location = new Point(391, 3);
            btnShorten.Name = "btnShorten";
            btnShorten.Size = new Size(120, 46);
            btnShorten.TabIndex = 0;
            btnShorten.Text = "Shorten URL";
            btnShorten.UseVisualStyleBackColor = true;
            btnShorten.Click += btnShorten_Click;
            // 
            // txtURL
            // 
            txtURL.Dock = DockStyle.Fill;
            txtURL.Location = new Point(3, 3);
            txtURL.Multiline = true;
            txtURL.Name = "txtURL";
            txtURL.PlaceholderText = "Enter or paste the URL here";
            txtURL.Size = new Size(382, 46);
            txtURL.TabIndex = 1;
            txtURL.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 60);
            label1.Margin = new Padding(6, 5, 5, 5);
            label1.Name = "label1";
            label1.Size = new Size(333, 15);
            label1.TabIndex = 2;
            label1.Text = "URL Shortener creates a shortened link making it easy to share";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label1, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutPanel5.Controls.Add(lblHeading, 0, 0);
            tableLayoutPanel5.Location = new Point(151, 6);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.Size = new Size(514, 217);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(btnReturn, 0, 5);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel4.Controls.Add(label2, 0, 3);
            tableLayoutPanel4.Controls.Add(label4, 0, 0);
            tableLayoutPanel4.Controls.Add(linkLabelLong, 0, 4);
            tableLayoutPanel4.Location = new Point(160, 6);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(406, 316);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 60);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(169, 15);
            label3.TabIndex = 3;
            label3.Text = "Copy the short url and share it!";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(3, 274);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(151, 38);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Shorten aother URL";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCopy, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 100);
            tableLayoutPanel2.Margin = new Padding(0, 20, 0, 20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(406, 50);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(319, 44);
            textBox1.TabIndex = 0;
            textBox1.WordWrap = false;
            // 
            // btnCopy
            // 
            btnCopy.Dock = DockStyle.Fill;
            btnCopy.Location = new Point(328, 3);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 44);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copy URL";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 194);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "Long URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 5);
            label4.Margin = new Padding(0, 5, 5, 5);
            label4.Name = "label4";
            label4.Size = new Size(318, 45);
            label4.TabIndex = 4;
            label4.Text = "Your shortened URL";
            // 
            // linkLabelLong
            // 
            linkLabelLong.AutoSize = true;
            linkLabelLong.Location = new Point(3, 214);
            linkLabelLong.Name = "linkLabelLong";
            linkLabelLong.Size = new Size(135, 15);
            linkLabelLong.TabIndex = 11;
            linkLabelLong.TabStop = true;
            linkLabelLong.Text = "https://www.demo.com";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(button1, 0, 2);
            tableLayoutPanel3.Controls.Add(possibleErrorList, 0, 1);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Location = new Point(155, 6);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(370, 410);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(3, 369);
            button1.Name = "button1";
            button1.Size = new Size(151, 38);
            button1.TabIndex = 7;
            button1.Text = "Try again";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // possibleErrorList
            // 
            possibleErrorList.AutoSize = true;
            possibleErrorList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            possibleErrorList.Location = new Point(5, 60);
            possibleErrorList.Margin = new Padding(5);
            possibleErrorList.Name = "possibleErrorList";
            possibleErrorList.Size = new Size(121, 15);
            possibleErrorList.TabIndex = 2;
            possibleErrorList.Text = "List of possible errors:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 5);
            label5.Margin = new Padding(0, 5, 5, 5);
            label5.Name = "label5";
            label5.Size = new Size(342, 45);
            label5.TabIndex = 1;
            label5.Text = "Failed to shorten URL";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "URL Shortener";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHeading;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnShorten;
        private TextBox txtURL;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox1;
        private Button btnCopy;
        private Button btnReturn;
        private Label label2;
        private TabPage tabPage3;
        private Label label5;
        private Label possibleErrorList;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private LinkLabel linkLabelLong;
    }
}
