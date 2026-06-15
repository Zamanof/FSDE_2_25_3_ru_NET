namespace NET_05._Partial;

partial class Form1
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
        clickButton = new Button();
        countLabel = new Label();
        SuspendLayout();
        // 
        // clickButton
        // 
        clickButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        clickButton.Location = new Point(367, 182);
        clickButton.Name = "clickButton";
        clickButton.Size = new Size(144, 44);
        clickButton.TabIndex = 0;
        clickButton.Text = "Click me";
        clickButton.UseVisualStyleBackColor = true;
        clickButton.Click += clickButton_Click;
        // 
        // countLabel
        // 
        countLabel.AutoSize = true;
        countLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
        countLabel.Location = new Point(220, 117);
        countLabel.Name = "countLabel";
        countLabel.Size = new Size(27, 32);
        countLabel.TabIndex = 1;
        countLabel.Text = "0";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(countLabel);
        Controls.Add(clickButton);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button clickButton;
    private Label countLabel;
}
