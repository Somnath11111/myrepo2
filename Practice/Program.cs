using System;
using System.Collections.Generic;

namespace MyApplication
{
    public class HelloWorld
    {
        //Kth Max and Kth Minimum in array(Selection sort algorithm)
        static void Main(string[] args)
        {
            int[] arr = { 12,7,18,0,6,19,81,9};
            int k = 4;
            int i, j=0, r, temp,mn,mx,kthMax;
            for(r=0;r<arr.Length-1; r++)
            {
                mn = arr[r];
                for(i=r+1;i<arr.Length;i++)
                {
                    if (arr[i] < mn)
                    {
                        j = i;
                        mn = arr[i];
                    }
                }
                if(r==k-1)
                {
                    temp = arr[r];
                    arr[r] = arr[j];
                    arr[j] = temp;
                    kthMax = arr[r];
                    Console.WriteLine("Kth (k={0}) min={1}", k,kthMax);
               
                }
                temp = arr[r];
                arr[r] = arr[j];
                arr[j] = temp;

            }
            for(i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();           
        }        
     }
}