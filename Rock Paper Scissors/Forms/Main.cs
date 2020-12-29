using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Main : Form
    {
        public int userScore = 0;
        public int computerScore = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void buttonPress(object sender, EventArgs e)
        {
            Button whatButton = (Button) sender;
            userChoice(whatButton.Text);
        }

        private void userChoice(String choice)
        {
            String computerChoice = getComputerChoice();
            switch (choice + computerChoice)
            {
                //win
                case "RockScissors":
                case "PaperRock":
                case "ScissorsPaper":
                    userWin(choice, computerChoice);
                    break;
                //loose
                case "ScissorsRock":
                case "RockPaper":
                case "PaperScissors":
                    userLoose(choice, computerChoice);
                    break;
                //draw
                case "RockRock":
                case "ScissorsScissors":
                case "PaperPaper":
                    battleDraw();
                    break;
            }
        }

        private void battleDraw()
        {
            statusLabel.Text = "draw";
            userScoreLabel.Text = "User: " + userScore;
            computerScoreLabel.Text = "Computer: " + computerScore;
        }

        private void userLoose(string choice, string computerChoice)
        {
            computerScore++;
            userScoreLabel.Text = "User: " + userScore;
            computerScoreLabel.Text = "Computer: " + computerScore;
            statusLabel.Text = "You loose!, " + choice + " looses to " + computerChoice;
        }

        private void userWin(string choice, string computerChoice)
        {
            userScore++;
            userScoreLabel.Text = "User: " + userScore;
            computerScoreLabel.Text = "Computer: " + computerScore;
            statusLabel.Text = "You win!, " + choice + " beats " + computerChoice;
        }


        private string getComputerChoice()
        {
            String[] choices = {"Rock","Paper","Scissors"};
            Random rnd = new Random();
            int randomInt = rnd.Next(0, 2);
           // int randomInt = (int) Math.Floor(rnd.NextDouble() * 3.0); need true random, help lol
            return choices[randomInt];

        }
   
    }
}
