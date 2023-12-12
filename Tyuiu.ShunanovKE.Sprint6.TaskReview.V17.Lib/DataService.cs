using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ShunanovKE.Sprint6.TaskReview.V17.Lib
{
    public class DataService
    {
        public int[,] GetRandMatrix(int n, int m, int n1, int n2)
        {
            Random rand = new Random();
            int[,] res = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 3 == 2)
                    {
                        res[i, j] = res[i, j - 1] * res[i, j - 2];
                    }
                    else
                    {
                        res[i, j] = rand.Next(n1, n2 + 1);
                    }
                }
            }
            return res;
        }
        public int GetMatrix(int[,] array, int k, int l, int r)
        {
            int res = 1;
            for (int i = k; i <= l; i+=2)
            {
                res *= array[r, i];
            }
            return res;
            
        }
    }
}
