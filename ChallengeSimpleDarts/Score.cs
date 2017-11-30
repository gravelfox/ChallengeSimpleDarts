using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static int ScoreRound(Dart luckyDart)
        {
            int score = 0;
            for (int i = 0; i < 3; i++)
            {
                luckyDart.Throw();
                score += luckyDart.Hit * luckyDart.Multiplier;
            }
            return score;
        }
    }
}