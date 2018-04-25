/*
    CHALLENGE - HourGlass Array

    Given a  2D Array, :

        1 1 1 0 0 0
        0 1 0 0 0 0
        1 1 1 0 0 0
        0 0 0 0 0 0
        0 0 0 0 0 0
        0 0 0 0 0 0

        We define an hourglass in  to be a subset of values with indices falling in this pattern in 's graphical representation:

            a b c
              d
            e f g

        There are hourglasses in , and an hourglass sum is the sum of an hourglass' values.

    Task
        
        Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.


    Input Format

        There are  lines of input, where each line contains  space-separated integers describing 2D Array ; every value in will be in the inclusive range of  to.

    Constraints

        -9 <= A[i][j] <= 9
         0 <= i,j <= 6

    Output Format

        Print the largest (maximum) hourglass sum found in .
*/
using System;

namespace HourGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = { new int[]{ 1, 1, 1, 0, 0, 0 }, new int[] { 0, 1, 0, 0, 0, 0}, new int[] { 1, 1, 1, 0, 0, 0}, new int[] { 0,0,2,4,4,0}, new int[] { 0,0,0,2,0,0}, new int[] { 0,0,1,2,4,0} };

            int rowCount = arr.Length;
            int colCount = arr[0].Length; //assume all rows have equal # of columns. Else exercise doesn't make sense.
            int maxValue = -72; //-9 is lowestvalue 7*-9 = -72
            int rowPointer = 0;            

            while (rowPointer < rowCount - 2)
            {
                int colPointer = 0;

                while (colPointer < colCount - 2)
                {
                    int firstRow = arr[rowPointer][colPointer] + arr[rowPointer][colPointer + 1] + arr[rowPointer][colPointer + 2];
                    int secondRow = arr[rowPointer + 1][colPointer + 1];
                    int thirdRow = arr[rowPointer+2][colPointer] + arr[rowPointer+2][colPointer + 1] + arr[rowPointer+2][colPointer + 2];
                    int result = firstRow + secondRow + thirdRow;
                    if(result > maxValue)
                    {
                        maxValue = result;
                    }
                    
                    colPointer++;
                }

                rowPointer++;
            }

            Console.Write(maxValue.ToString());
            Console.ReadLine();
        }
    }
}
