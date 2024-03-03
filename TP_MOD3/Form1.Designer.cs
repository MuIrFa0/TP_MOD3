namespace TP_MOD3
{
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
            Submit = new Button();
            Input = new Label();
            Output = new Label();
            SuspendLayout();
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ControlDark;
            Submit.Location = new Point(468, 110);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 0;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Input
            // 
            Input.BackColor = SystemColors.ControlDark;
            Input.Location = new Point(234, 113);
            Input.Name = "Input";
            Input.Size = new Size(191, 20);
            Input.TabIndex = 1;
            Input.Text = "Input";
            Input.TextAlign = ContentAlignment.MiddleCenter;
            Input.Click += Input_Click;
            // 
            // Output
            // 
            Output.BackColor = SystemColors.ControlDark;
            Output.Location = new Point(234, 193);
            Output.Name = "Output";
            Output.Size = new Size(309, 23);
            Output.TabIndex = 2;
            Output.Text = "Output";
            Output.TextAlign = ContentAlignment.MiddleCenter;
            Output.Click += Output_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output);
            Controls.Add(Input);
            Controls.Add(Submit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Submit;
        private Label Input;
        private Label Output;
    }
}
