using ProjectEuler.Utilities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    class Problem11 : IProblem
    {
        private int[][] m_grid;
        private int m_lineSize;
        private int m_gridSize;

        public Problem11(string grid,int lineSize)
        {
            m_lineSize = lineSize;
            int[] numbers = grid.Split(' ','\n').Where(s => !string.IsNullOrEmpty(s)).Select(n => int.Parse(n)).ToArray();

            m_gridSize = (int)Math.Sqrt(numbers.Length);

            m_grid = new int[m_gridSize][];
            for (int i = 0; i < m_gridSize; i++)
            {
                m_grid[i] = new int[m_gridSize];
                for (int j = 0; j < m_gridSize; j++)
                {
                    m_grid[i][j] = numbers[i*m_gridSize+j];
                }
            }
        }

        public long Run()
        {
            long max = 0;

            for (int i = 0; i < m_gridSize; i++)
            {
                for (int j = 0; j < m_gridSize; j++)
                {

                    //check row
                    if (j + m_lineSize <= m_gridSize)
                    {
                        long product = m_grid[i].Skip(j).Take(m_lineSize).Product();
                        if (product > max)
                        {
                            max = product;
                        }
                    }

                    //check column
                    if (i + m_lineSize <= m_gridSize)
                    {
                        long product = 1;
                        for (int n = 0; n < m_lineSize; n++)
                        {
                            product *= m_grid[i + n][j];
                        }
                        if (product > max)
                        {
                            max = product;
                        }
                    }

                    //check \ diagnal
                    if (i+ m_lineSize <= m_gridSize && j+m_lineSize <= m_gridSize)
                    {
                        long product = 1;
                        for (int n = 0; n < m_lineSize; n++)
                        {
                            product *= m_grid[i + n][j+n];
                        }
                        if (product > max)
                        {
                            max = product;
                        }
                    }

                    //check / diagnal
                    if (i>= m_lineSize && j + m_lineSize <= m_gridSize)
                    {
                        long product = 1;
                        for (int n = 0; n < m_lineSize; n++)
                        {
                            product *= m_grid[i - n][j + n];
                        }
                        if (product > max)
                        {
                            max = product;
                        }
                    }
                }
            }


            return max;
        }

    }
}
