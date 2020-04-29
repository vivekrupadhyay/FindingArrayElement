using System;

namespace secondHeighestArrayElement {
    class GFG {
        public static void PrintLargest (int[] arr, int arr_size) {
            int first, second;
            if (arr_size < 2) {
                Console.WriteLine ("Invalid Input");
                return;
            }
            first = second = 0;
            for (int i = 0; i < arr_size; i++) {
                if (arr[i] > first) {
                    second = first;
                    first = arr[i];
                } else if (arr[i] > second) {
                    second = arr[i];
                }
            }

            Console.WriteLine ("Largest No is. " + first);

            Console.WriteLine ("Second Largest No is " + second);

        }
    }
    class Program {
        static void Main (string[] args) {
            int[] arr = { 12, 34, 35, 20, 9, 8, 10 };
            // int n = arr.Length;

            // GFG.PrintLargest (arr, n);
            int max = 0;
            int smax = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > max) {
                    smax = max;
                    max = arr[i];
                } else if (arr[i] > smax) {
                    smax = arr[i];
                }
            }
              Console.WriteLine ("Largest No is. " + max);

            Console.WriteLine ("Second Largest No is " + smax);
        }
    }
}