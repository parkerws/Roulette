using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace Roulette.Game
{
    class Bets
    {
        public static Dictionary<int, string> Numbers = new Dictionary<int, string>
        {

            {0, "green"},
            {1, "red"},
            {2, "black"},
            {3, "red"},
            {4, "black"},
            {5, "red"},
            {6, "black"},
            {7, "red"},
            {8, "black"},
            {9, "red"},
            {10, "black"},
            {11, "black"},
            {12, "red"},
            {13, "black"},
            {14, "red"},
            {15, "black"},
            {16, "red"},
            {17, "black"},
            {18, "red"},
            {19, "red"},
            {20, "black"},
            {21, "red"},
            {22, "black"},
            {23, "red"},
            {24, "black"},
            {25, "red"},
            {26, "black"},
            {27, "red"},
            {28, "black"},
            {29, "black"},
            {30, "red"},
            {31, "black"},
            {32, "red"},
            {33, "black"},
            {34, "red"},
            {35, "black"},
            {36, "red"},
            {37, "green"}
            
        };

        private readonly int[] firstCol = new int[]
            {1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34};
        private readonly int[] secondCol = new int[]
            {2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35};
        private readonly int[] thirdCol = new int[]
            {3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36};


        public string EvensOdds(int bin)
        {
            
            if (bin == 37)
            {
                return "00 is not odd or even.";
            }
            else if (bin == 0)

            {
                return "0 is not odd or even.";
            }
            else
            {
                if (bin % 2 == 0)
                {
                    return $"An even number, {bin}, is the winner.";
                }
                else
                {
                    return $"An odd number, {bin}, is the winner.";
                }
            }
        }

        public string RedsOrBlacks(int bin)
        {
            
            if (bin == 37)
            {
                return "00 is green.";
            }
            else if (bin == 0)
            {
                return "0 is green.";
            }
            else
            {
                if (Numbers[bin] == "red")
                {
                    return $"The winning bet is {bin} red.";
                }
                else
                {
                    return $"The winning bet is {bin} black";
                }
            }
        }

        public string LowsAndHighs(int bin)
        {
            if (bin == 37)
            {
                return "00 is not in the range.";
            }
            else if (bin == 0)
            {
                return "0 is not in the range.";
            }
            else
            {
                if (bin > 0 && bin <= 18)
                {
                    return $"Lows wins, with {bin}.";
                }
                else
                {
                    return $"Highs wins, with {bin}.";
                }
            }
        }

        public string Dozens(int bin)
        {
            if (bin == 37)
            {
                return "00 is not odd or even.";
            }
            else if (bin == 0)

            {
                return "0 is not odd or even.";
            }
            else
            {
                if (bin > 0 && bin <= 12)
                {
                    return $"First 12 wins, with {bin}.";
                }
                else if (bin > 12 && bin <= 24)
                {
                    return $"Second 12 wins, with {bin}.";
                }
                else
                {
                    return $"Third 12 wins, with {bin}.";
                }
            }
        }

        public string Columns(int bin)
        {

            int[] column = new int[firstCol.Length];
            if (bin == 37)
            {
                return "00 is not in the range.";
            }
            else if (bin == 0)
            {
                return "0 is not in the range.";
            }
            else
            {
                
                for (int i = 0; i < 3; i++)
                {
                    if (firstCol.Contains(bin))
                    {
                        for (int k = 0; k < column.Length; k++)
                        {
                            column[k] = firstCol[k];
                        }
                    }
                    else if (secondCol.Contains(bin))
                    {
                        for (int k = 0; k < column.Length; k++)
                        {
                            column[k] = secondCol[k];
                        }
                    }
                    else
                    {
                        for (int k = 0; k < column.Length; k++)
                        {
                            column[k] = thirdCol[k];
                        }
                    }
                }
            }
            string ans = "";
            foreach (var item in column)
            {
                ans += item.ToString() + "/";
            }
            return $"The winning group is {ans}";
        }

        public string Street(int bin)
        {
            var range = new int[3];
            if (bin == 37)
            {
                return "00 is not odd or even.";
            }
            else if (bin == 0)

            {
                return "0 is not odd or even.";
            }
            else
            {
                if (bin % 3 == 0)
                {
                    range[0] = bin - 2;
                    range[1] = bin - 1;
                    range[2] = bin;
                }
                else if (bin % 3 == 2)
                {
                    range[0] = bin - 1;
                    range[1] = bin;
                    range[2] = bin + 1;
                }
                else if (bin % 3 == 1)
                {
                    range[0] = bin;
                    range[1] = bin + 1;
                    range[2] = bin + 2;
                }

                return $"The winning street is {range[0]}, {range[1]}, and {range[2]}";

            }
        }

        public string SixNumbers(int bin)
        {
            var range = new int[6,6]
            {
                {1, 2, 3, 4, 5, 6 },
                {7, 8, 9, 10, 11, 12 },
                {13, 14, 15, 16, 17, 18 },
                {19, 20, 21, 22, 23, 24 },
                {25, 26, 27, 28, 29, 30 },
                {31, 32, 33, 34, 35, 36 }
            };
            int[] answer = new int[6];
            if (bin == 37)
            {
                return "00 is not odd or even.";
            }
            else if (bin == 0)

            {
                return "0 is not odd or even.";
            }
            else
            {
                for (int i = 0; i < range.GetLength(0); i++)
                {
                    for (int j = 0; j < range.GetLength(1); j++)
                    {
                        if (bin == range[i, j])
                        {
                            
                            for (int k = 0; k < range.GetLength(1); k++)
                            {
                                answer[k] = range[i, k];
                            }
                        }
                    }
                }  
            }
            string ans = "";
            foreach (var item in answer)
            {
                ans += item.ToString() + "/";
            }
            return $"The winning group is {ans}";
        }
         
        public string Split(int bin)
        {
            int[] splitarray = new int[5];
            int[] positions = new int[] {1, -1, 3, -3};
            splitarray[0] = bin;

            for (int i = 1; i < positions.Length; i++)
            {
                if (bin + positions[i] < 37 && positions[i] > 0)
                {
                    splitarray[i] = bin + positions[i];
                }
                

            }

            string winnings = "";
            for (int i = 0; i < positions.Length; i++)
            {
                winnings += $"{bin}/{positions[i]+bin} or ";
            }

            return $"The winning splits are {winnings}";


        }

        public string Corner(int bin)
        {
            int[,] combinations;
            int[] column = new int[firstCol.Length];
            int columnNum = 0;
            int[,] positions = new int[,]
            {
                {bin, bin+1, bin+3, bin+4},
                {bin-3, bin-2, bin, bin+1},
                {bin-1, bin, bin+2, bin-3},
                {bin-4, bin-3, bin-1, bin}
            };

            if (bin == 37)
            {
                return "00 is not in the range.";
            }
            else if (bin == 0)
            {
                return "0 is not in the range.";
            }
            else
            {
                if (firstCol.Contains(bin))
                {
                    combinations = new int[2,4];

                    for (int i = 0; i < combinations.GetLength(0); i++)
                    {
                        for (int j = 0; j < combinations.GetLength(1); j++)
                        {
                            combinations[i, j] = positions[i, j];
                        }
                    }
                }
                else if (thirdCol.Contains(bin))
                {
                    combinations = new int[2,4];

                    for (int i = 0; i < combinations.GetLength(0); i++)
                    {
                        for (int j = 0; j < combinations.GetLength(1); j++)
                        {
                            combinations[i, j] = positions[i + 2, j];
                        }
                    }
                }
                else
                {
                    combinations = new int[4,4];

                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            combinations[i, j] = positions[i, j];
                        }
                    }
                }

            }

            string winnings = "";

            for (int i = 0; i < combinations.GetLength(0); i++)
            {
                for (int j = 0; j < combinations.GetLength(1); j++)
                {
                    if (combinations[i, j] < 0 || combinations[i, j] > 34)
                    {
                        break;
                    }
                    winnings += $"{combinations[i, j]}/";
                }

                winnings += ", ";

            }

            return $"The winning splits are {winnings}";

        }


    }
}
