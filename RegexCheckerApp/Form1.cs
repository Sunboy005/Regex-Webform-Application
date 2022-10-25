using System.Text.RegularExpressions;

namespace RegexCheckerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;
            string regex = txtRegex.Text;
            Regex rgx = new Regex(regex);
            bool result = rgx.IsMatch(text);
            MessageBox.Show(result.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}