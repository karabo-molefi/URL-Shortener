using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace URL_Shortener
{
    public partial class MainForm : Form
    {
        private bool allowTabChange = false;

        public MainForm()
        {
            InitializeComponent();

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabStop = false;

            tabControl1.Selecting += tabControl1_Selecting;

            possibleErrorList.Text = string.Join("\r\n", new[]
            {
                "List of possible errors:",
                "",
                "✔ Incorrect domain: Check for typos.",
                "",
                "✔ Site offline: Confirm the website is running.",
                "",
                "✔ Formatting error: Check punctuation and typos.",
                "",
                "✔ Spam risk: The link may be flagged as spam.",
                "",
                "✔ Blocked link: This URL is restricted.",
                "",
                "✔ Reported URL: Users or safety systems flagged it.",
                "",
                "✔ Duplicate request: This URL was already shortened recently.",
                "",
                "✔ Prohibited content: The link violates our policies.",
                "",
                "✔ Rate limit: Too many links created in a short time."
            });


        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowTabChange) e.Cancel = true;
        }

        private void GoToTab(int index)
        {
            allowTabChange = true;
            tabControl1.SelectedIndex = index;
            allowTabChange = false;
        }

        private void btnShorten_Click(object sender, EventArgs e)
        {
            linkLabelLong.Text = txtURL.Text;
            GoToTab(1);

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            GoToTab(2);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            GoToTab(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoToTab(0);
        }
    }
}
