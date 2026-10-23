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
            button1 = new Button();
            txtURL = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(162, 62);
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
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(txtURL, 0, 0);
            tableLayoutPanel1.Location = new Point(107, 146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(590, 31);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(467, 3);
            button1.Name = "button1";
            button1.Size = new Size(120, 25);
            button1.TabIndex = 0;
            button1.Text = "Shorten URL";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtURL
            // 
            txtURL.Dock = DockStyle.Fill;
            txtURL.Location = new Point(3, 3);
            txtURL.Multiline = true;
            txtURL.Name = "txtURL";
            txtURL.PlaceholderText = "Enter or paste the URL here";
            txtURL.Size = new Size(458, 25);
            txtURL.TabIndex = 1;
            txtURL.TextAlign = HorizontalAlignment.Center;
            txtURL.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 209);
            label1.Name = "label1";
            label1.Size = new Size(333, 15);
            label1.TabIndex = 2;
            label1.Text = "URL Shortener creates a shortened link making it easy to share";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblHeading);
            Name = "Form1";
            Text = "URL Shortener";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TextBox txtURL;
        private Label label1;
    }
}
