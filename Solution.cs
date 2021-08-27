using System;
using System.Collections.Generic;
using System.Text;

namespace MissingInteger
{
    class Solution
    {
        //Write a function:

        //class Solution { public int solution(int[] A); }

        //that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.

        //For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

        //  Given A = [1, 2, 3], the function should return 4.

        //  Given A = [−1, −3], the function should return 1.

        //Write an efficient algorithm for the following assumptions:

        //N is an integer within the range[1..100, 000];
        //each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].
        public int solution(int[] A)
        {

            int[] compareList = new int[1000001];


            for (int i = 0; i < A.Length; i++)
            {

                if (A[i] <= 0)
                {
                    continue;
                }

                if (compareList[i] == A[i] && compareList[i] != 0)
                {
                    continue;
                }
                compareList.SetValue(i + 1, A[i]);

            }

            if (compareList == new int[1000000])
            {
                return 1;
            }
            for (int i = 1; i < compareList.Length; i++)
            {

                if (compareList[i] == 0)
                {

                    return i;
                }


            }


            return 1;

        }

    }
}
