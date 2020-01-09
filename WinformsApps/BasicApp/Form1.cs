using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicApp
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private int _numberToGuess;
        public Form1()
        {
            InitializeComponent();
            messageLabel.Text = "Press the button to start a new game";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Guess a number from 1 to 100";
            startButton.Enabled = false;
            _numberToGuess = _random.Next(1, 101);

            guessInput.Enabled = true;
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            string input = guessInput.Text;
            guessInput.Text = "";
            
            int result = int.Parse(input);
            
            if (result > _numberToGuess)
            {
                messageLabel.Text = "Too big. Guess again";
            }
            else if(result < _numberToGuess)
            {
                messageLabel.Text = "Too small. Guess again";
            }
            else
            {
                messageLabel.Text = "You did it !!! Press the start button for another game";
                startButton.Enabled = true;
                guessButton.Enabled = false;
                guessInput.Enabled = false;
            }
        }

        private void guessInput_TextChanged(object sender, EventArgs e)
        {
            string input = guessInput.Text;
            int result;
            bool validNumber = int.TryParse(input, out result);
            if (!validNumber || result < 1 || result > 100)
            {
                guessButton.Enabled = false;
            }
            else
            {
                guessButton.Enabled = true;
            }
        }
    }
}
