namespace AnchorAndDockDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bAnchorDemo_Click(object sender, EventArgs e)
        {
            var f = new AnchorDemoForm();
            f.ShowDialog();
        }

        private void bDockDemo_Click(object sender, EventArgs e)
        {
            var f = new DockDemoForm();
            f.ShowDialog();
        }
    }
}