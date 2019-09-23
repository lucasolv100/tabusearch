
using System;
using System.Collections.Generic;
using System.Linq;

namespace TabuSearch
{
    public class TSearchAlgorithm
    {
        private List<int[]> tabuList = new List<int[]>();
        public TSearchAlgorithm()
        {
            for (int i = 0; i < Contants.interactions; i++)
            {
                int[] solution = new int[12];

                for (int j = 0; j < solution.Length; j++)
                {
                    solution[j] = (Contants.random.NextDouble() >= 0.5f) ? 1 : 0;
                }

                double result = 0;
                result = Shopping.ObjectiveFunction(solution);

                if (result == 0)
                {
                    if (!tabuList.Contains(solution))
                    {
                        tabuList.Add(solution);
                    }
                    else
                    {
                        i = 0;
                    }
                }
                else
                {
                    for (int l = 0; l < solution.Length; l++)
                    {
                        Console.Write(solution[l].ToString());    
                    }
                }
            }
        }
    }
}