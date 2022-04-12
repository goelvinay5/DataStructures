using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Array
    {
        public int[] arr { get; set; }
        public int n { get; set; }

        //Juggling Algorithm
        static void leftRotate(int[] arr, int d, int n)
        {
            int i, j, k, temp;
            /* To handle if d >= n */
            d = d % n;
            int g_c_d = gcd(d, n);
            for (i = 0; i < g_c_d; i++)
            {
                /* move i-th values of blocks */
                temp = arr[i];
                j = i;
                while (true)
                {
                    k = j + d;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;
                    arr[j] = arr[k];
                    j = k;
                }
                arr[j] = temp;
            }
        }
        //Euclids Algo
        static int gcd(int a, int b)
        {
            //if (b == 0)
            //    return a;
            //else
            //    return gcd(b, a % b);

            while (b != 0)
            {
                int _b = b;
                int _a = a % b;
                a = _b;
                b = _a;
            }
            return a;
        }

        public int[] rotateArray(int d)
        {
            leftRotate(arr, d, n);
            return arr;
        }
    }
}
