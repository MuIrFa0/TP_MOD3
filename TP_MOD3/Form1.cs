using Microsoft.VisualBasic;

namespace TP_MOD3
{
    public partial class Form1 : Form
    {
        private string InputText = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, EventArgs e)
        {
            InputText = Interaction.InputBox("Enter text: ", "Input", InputText);
        }

        private void Output_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User Input: {InputText} ", "Output");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Output_Click(sender, e);
        }
    }
}
