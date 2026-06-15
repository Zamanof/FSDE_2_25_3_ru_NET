namespace NET_05._Partial;

public partial class Form1 : Form
{
    static int count = 0;
    public Form1()
    {
        InitializeComponent();
    }

    private void clickButton_Click(object sender, EventArgs e)
    {
        count++;
        countLabel.Text = getCount;
    }
    private string getCount => count.ToString();
}
