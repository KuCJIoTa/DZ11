using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ11
{
    public partial class Form1 : Form
    {
        private int secretNumber;
        private int attempts;
        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }
        private void StartNewGame()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
            attempts = 0;
            lblMessage.Text = "Угадайте число от 1 до 100";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int guess;
            if (int.TryParse(txtGuess.Text, out guess))
            {
                attempts++;
                if (guess == secretNumber)
                {
                    MessageBox.Show($"Поздравляем! Вы угадали число за {attempts} попыток.", "Победа!");
                    StartNewGame();
                }
                else if (guess < secretNumber)
                {
                    lblMessage.Text = "Загаданное число больше";
                }
                else
                {
                    lblMessage.Text = "Загаданное число меньше";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное число.", "Ошибка");
            }
            txtGuess.Text = "";
        }
    

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
