namespace URL_Shortener
{
    public partial class MainForm : Form
    {
        private readonly UrlService urlService = new UrlService();
        private bool allowTabChange = false;

        public MainForm()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabStop = false;
            tabControl1.Selecting += tabControl1_Selecting;

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

        private async void btnShorten_Click(object sender, EventArgs e)
        {
            btnShorten.Enabled = false;
            try
            {
                string shortUrl = await urlService.ShortenAsync(txtURL.Text.Trim());
                linkLabelLong.Text = txtURL.Text.Trim();
                txtShortUrl.Text = shortUrl;
                GoToTab(1);
            }
            catch (Exception ex)
            {
                txtURL.Clear();
                MessageBox.Show(ex.Message, "Failed to shorten url");
            }
            finally
            {
                btnShorten.Enabled = true;
            }
  
        }
        private async void btnCopy_Click(object sender, EventArgs e)
        {
            string textToCopy = txtShortUrl.Text;

            try
            {
                Clipboard.SetText(textToCopy);
                string original = btnCopy.Text;
                btnCopy.Text = "Copied ✔";
                btnCopy.Enabled = false;
                await Task.Delay(1500);
                btnCopy.Text = original;
                btnCopy.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't copy to clipboard. Please try again.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            txtURL.Clear();
            GoToTab(0);
        }

    }
}
