using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private int player1Score { get; set; }
        private int player2Score { get; set; }
        public Random fatesWhim { get; set; }

        public Game()
        {
            this.player1Score = 0;
            this.player2Score = 0;
            this.fatesWhim = new Random();
        }

        public void PlayGame()
        {
            Dart luckyDart = new Dart(fatesWhim);
            while (player1Score < 300 && player2Score < 300)
            {
                player1Score += Score.ScoreRound(luckyDart);
                player2Score += Score.ScoreRound(luckyDart);
            }
        }

        public void PrintResult(Label outcome, Label play1, Label play2)
        {
            string winner = (player1Score > player2Score) ? "Player 1" :
                (player2Score > player1Score) ? "Player 2" : "Tie Game";
            play1.Text = "Player 1: " + this.player1Score;
            play2.Text = "Player 2: " + this.player2Score;
            outcome.Text = string.Format("Winner: {0}", winner);
        }
    }
}