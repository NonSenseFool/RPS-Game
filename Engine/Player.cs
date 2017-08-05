using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player
    {
        public string WeaponName;

        public Player()
        {
        }

        public string AIRandomize(out string result)
        {
            Random rnd = new Random();
            int rng = rnd.Next(1, 4);
            if (rng == 1)
            {
                result = "rock";
                return result;
            }
            else if (rng == 2)
            {
                result = "paper";
                return result;
            }
            else if (rng == 3)
            {
                result = "scissors";
                return result;
            }
            else
            {
                result = "invalid";
                return result;
            }
        }

        public string CheckEffectiveness(string playerType, string aiType)
        {
            if (playerType == "rock")
            {
                switch (aiType)
                {
                    case "rock":
                        {
                            return "tie";
                        }
                    case "paper":
                        {
                            return "lose";
                        }
                    case "scissors":
                        {
                            return "win";
                        }
                }
            }
            else if (playerType == "paper")
            {
                switch (aiType)
                {
                    case "rock":
                        {
                            return "win";
                        }
                    case "paper":
                        {
                            return "tie";
                        }
                    case "scissors":
                        {
                            return "lose";
                        }
                }
            }
            else if (playerType == "scissors")
            {
                switch (aiType)
                {
                    case "rock":
                        {
                            return "lose";
                        }
                    case "paper":
                        {
                            return "win";
                        }
                    case "scissors":
                        {
                            return "tie";
                        }
                }
            }
            else
            {
                // Improper weapon was chosen
                return null;
            }
            return null;
        }
    }
}
