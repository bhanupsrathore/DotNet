namespace BasicDesktopApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void theCircle_Click(object sender, EventArgs e)
    {
        outputLabel.Text = DateTime.Now.ToString();
    }
}
