using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodigy_infotech_task_2
{
    public partial class Form1 : Form
    {
        int guess;
        int attempts;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Luckbtn_Click(object sender, EventArgs e)
        { 
                                  
            
            if (int.TryParse(Guessbox.Text, out int playerGuess))
            {
                ++ attempts;

                if (playerGuess == guess)
                {
                    MessageBox.Show($"YOU WIN! Attempts: {attempts} ");
                    ResetGame();
                }
                else
                {
                    NumAtt.Text = $"TRY AGAIN! Attempts: {attempts}";
                }
            }
            else
            {
                MessageBox.Show("Please enter a number between 1 and 5");
            }
        }
        private void ResetGame()
        {
            Random random = new Random();
            guess = random.Next(1, 6); // Generate a new random number between 1 and 5
            attempts = 0; // Reset attempts
            Guessbox.Clear(); // Clear the input box
            NumAtt.Text = ""; // Clear the attempts label
        }
        private void NumAtt_Click(object sender, EventArgs e)
        {

        }
    }
}
