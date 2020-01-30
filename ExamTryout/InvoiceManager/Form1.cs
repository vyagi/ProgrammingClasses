using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            string path = pathTextBox.Text;
            if(!File.Exists(path))
            {
                MessageBox.Show("The file does not exist");
                return;
            }

            string[] content = File.ReadAllLines(path);
            int totalSum = 0;
            List<string> dates = new List<string>();
            for (int i = 1; i < content.Length; i++)
            {
                string line = content[i];
                string[] elements = line.Split('\t');
                totalSum = totalSum + int.Parse(elements[1]);

                if (!dates.Contains(elements[0]))
                {
                    dates.Add(elements[0]);
                }
            };
            string message = $"Total dates: {dates.Count}, total amount {totalSum}.";
            resultLabel.Text = message;
        }
    }
}
