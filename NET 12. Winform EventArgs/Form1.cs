namespace NET_12._Winform_EventArgs;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Calculator(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        double firstValue = default;
        double.TryParse(firstTextBox.Text, out firstValue);
        double secondValue = default;
        double.TryParse(secondTextBox.Text, out secondValue);
        double result = default;
        if (button.Text == "Add")
        {
            resultLabel.Text = result.ToString();
        }
        else if (button.Text == "Subtract")
        {
            resultLabel.Text = result.ToString();
        }
        else if (button.Text == "Multiply")
        {
            resultLabel.Text = result.ToString();
        }
        else if (button.Text == "Divide")
        {
            if(secondValue != 0) 
            {
                resultLabel.Text = result.ToString();
            }
            else
            {
                resultLabel.Text = "Cannot divide by zero!";
            }
        }
        firstTextBox.Clear();
        secondTextBox.Clear();
    }
}