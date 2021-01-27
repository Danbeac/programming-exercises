﻿using System;

namespace programming_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //FuncionAlgBubbleSort();
            //FuncionAlgSelectionSort();
            FuncionInsertionSort();
        }

        public static void FuncionAlgBubbleSort()
        {
            int[] arr = new int[]{10,5,9,7,24,29,2};
            
            for(int i = 0 ; i < arr.Length ; i++)
            {
                for(int j = 0; j < arr.Length - i- 1;j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }

        public static void FuncionAlgSelectionSort()
        {
            int[] arr = new int[]{5,7,1,9,12,10,16,20,3};

            for(int i = 0; i < arr.Length; i++)
            {
                int index = i;
                
                for(int j = i + 1;j < arr.Length; j++)
                {
                    if(arr[index] > arr[j])
                    {
                        index = j;
                    }
                }
                (arr[i],arr[index]) = (arr[index],arr[i]);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }

        private static void FuncionInsertionSort()
        {
            int[] arr = {59,74,86,94,78,57,64,85,79};
            
            for(int i = 0; i < arr.Length;i++)
            {
                var val = arr[i];
                int index = i;

                while(index > 0 && arr[index-1] > val)
                {
                    arr[index] = arr[index-1];
                    index = index - 1;
                } 

                arr[index] = val;
            }

            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
