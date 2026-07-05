namespace NET_12._Winform_EventArgs;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        firstTextBox = new System.Windows.Forms.TextBox();
        secondTextBox = new System.Windows.Forms.TextBox();
        addButton = new System.Windows.Forms.Button();
        subdtractButton = new System.Windows.Forms.Button();
        multiplyButton = new System.Windows.Forms.Button();
        divideButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        resultLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // firstTextBox
        // 
        firstTextBox.Location = new System.Drawing.Point(40, 69);
        firstTextBox.Name = "firstTextBox";
        firstTextBox.Size = new System.Drawing.Size(100, 23);
        firstTextBox.TabIndex = 0;
        // 
        // secondTextBox
        // 
        secondTextBox.Location = new System.Drawing.Point(203, 69);
        secondTextBox.Name = "secondTextBox";
        secondTextBox.Size = new System.Drawing.Size(100, 23);
        secondTextBox.TabIndex = 1;
        // 
        // addButton
        // 
        addButton.Location = new System.Drawing.Point(138, 145);
        addButton.Name = "addButton";
        addButton.Size = new System.Drawing.Size(75, 23);
        addButton.TabIndex = 2;
        addButton.Text = "Add";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += Calculator;
        // 
        // subdtractButton
        // 
        subdtractButton.Location = new System.Drawing.Point(138, 174);
        subdtractButton.Name = "subdtractButton";
        subdtractButton.Size = new System.Drawing.Size(75, 23);
        subdtractButton.TabIndex = 3;
        subdtractButton.Text = "Subtract";
        subdtractButton.UseVisualStyleBackColor = true;
        subdtractButton.Click += Calculator;
        // 
        // multiplyButton
        // 
        multiplyButton.Location = new System.Drawing.Point(138, 203);
        multiplyButton.Name = "multiplyButton";
        multiplyButton.Size = new System.Drawing.Size(75, 23);
        multiplyButton.TabIndex = 4;
        multiplyButton.Text = "Multiply";
        multiplyButton.UseVisualStyleBackColor = true;
        multiplyButton.Click += Calculator;
        // 
        // divideButton
        // 
        divideButton.Location = new System.Drawing.Point(138, 232);
        divideButton.Name = "divideButton";
        divideButton.Size = new System.Drawing.Size(75, 23);
        divideButton.TabIndex = 5;
        divideButton.Text = "Divide";
        divideButton.UseVisualStyleBackColor = true;
        divideButton.Click += Calculator;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(40, 43);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 6;
        label1.Text = "First value";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(203, 43);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 7;
        label2.Text = "Second Value";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label3.Location = new System.Drawing.Point(101, 95);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(140, 36);
        label3.TabIndex = 8;
        label3.Text = "Result:";
        // 
        // resultLabel
        // 
        resultLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        resultLabel.Location = new System.Drawing.Point(187, 95);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new System.Drawing.Size(100, 36);
        resultLabel.TabIndex = 9;
        resultLabel.Text = "0";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(355, 297);
        Controls.Add(resultLabel);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(divideButton);
        Controls.Add(multiplyButton);
        Controls.Add(subdtractButton);
        Controls.Add(addButton);
        Controls.Add(secondTextBox);
        Controls.Add(firstTextBox);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox firstTextBox;
    private System.Windows.Forms.TextBox secondTextBox;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button subdtractButton;
    private System.Windows.Forms.Button multiplyButton;
    private System.Windows.Forms.Button divideButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label resultLabel;

    #endregion
}