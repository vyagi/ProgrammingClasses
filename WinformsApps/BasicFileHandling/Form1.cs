using System.IO;
using System.Windows.Forms;

namespace BasicFileHandling
{
    public partial class Form1: Form
    {
        private string _path = @"C:\Users\MJAGIELA\Desktop\Sample.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, System.EventArgs e)
        {
            contentTextBox.Text = File.ReadAllText(_path);
        }

        private void saveButton_Click(object sender, System.EventArgs e)
        {
            File.WriteAllText(_path, contentTextBox.Text);
        }
    }
}
