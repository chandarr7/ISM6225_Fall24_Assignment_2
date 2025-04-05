using System;
using System.Collections.Generic;

namespace ISM6225_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================================================
            // Test Case 1: Find Missing Numbers in Array
            // ---------------------------------------------------------------
            // Input: {4, 3, 2, 7, 8, 2, 3, 1}
            // Expected Missing: [5, 6]
            int[] arr1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            List<int> missingNumbers = FindMissingNumbers(arr1);
            Console.WriteLine("Missing Numbers: " + string.Join(", ", missingNumbers));

            // ================================================================
            // Test Case 2: Sort Array by Parity
            // ---------------------------------------------------------------
            // Input: {3, 1, 2, 4}
            // Expected Output: Even numbers first (e.g., 2, 4) then odd numbers (e.g., 3, 1)
            int[] arr2 = { 3, 1, 2, 4 };
            SortArrayByParity(arr2);
            Console.WriteLine("Sorted by Parity: " + string.Join(", ", arr2));

            // ================================================================
            // Test Case 3: Two Sum
            // ---------------------------------------------------------------
            // Input: {2, 7, 11, 15} with target 9
            // Expected Output: Indices [0, 1] (because 2 + 7 = 9)
            int[] arr3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(arr3, target);
            Console.WriteLine("Two Sum Indices: " + string.Join(", ", indices));

            // ================================================================
            // Test Case 4: Find Maximum Product of Three Numbers
            // ---------------------------------------------------------------
            // Input: {1, 2, 3, 4}
            // Expected Output: 24 (the product of the three largest numbers)
            int[] arr4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProductOfThreeNumbers(arr4);
            Console.WriteLine("Maximum Product of Three Numbers: " + maxProduct);

            // ================================================================
            // Test Case 5: Decimal to Binary Conversion
            // ---------------------------------------------------------------
            // Input: 42
            // Expected Output: "101010"
            int number = 42;
            string binary = DecimalToBinary(number);
            Console.WriteLine("Decimal " + number + " in binary: " + binary);

            // ================================================================
            // Test Case 6: Find Minimum in Rotated Sorted Array
            // ---------------------------------------------------------------
            // Input: {4, 5, 6, 7, 0, 1, 2}
            // Expected Output: 0
            int[] arr6 = { 4, 5, 6, 7, 0, 1, 2 };
            int minElement = FindMinInRotatedSortedArray(arr6);
            Console.WriteLine("Minimum in Rotated Sorted Array: " + minElement);

            // ================================================================
            // Test Case 7: Palindrome Number
            // ---------------------------------------------------------------
            // Input: 121
            // Expected Output: True
            int x = 121;
            bool isPalin = IsPalindrome(x);
            Console.WriteLine("Is " + x + " a palindrome? " + isPalin);

            // ================================================================
            // Test Case 8: Fibonacci Number
            // ---------------------------------------------------------------
            // Input: n = 4
            // Expected Output: Fibonacci(4) = 3 (Sequence: 0, 1, 1, 2, 3, ...)
            int n = 4;
            int fib = Fibonacci(n);
            Console.WriteLine("Fibonacci(" + n + "): " + fib);
        }

        // ================================================================
        // Method 1: Find Missing Numbers in Array
        // ---------------------------------------------------------------
        // Given an array containing numbers 1 to n (with possible duplicates),
        // this method finds the numbers that are missing.
        public static List<int> FindMissingNumbers(int[] nums)
        {
            int n = nums.Length;
            // Create a boolean array to track the presence of numbers (1-indexed).
            bool[] present = new bool[n + 1];

            // Mark numbers that appear in the array.
            foreach (int num in nums)
            {
                if (num >= 1 && num <= n)
                {
                    present[num] = true;
                }
            }

            // Collect numbers that are not present.
            List<int> missing = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (!present[i])
                {
                    missing.Add(i);
                }
            }
            return missing;
        }

        // ================================================================
        // Method 2: Sort Array by Parity
        // ---------------------------------------------------------------
        // This method rearranges the array so that all even numbers come before odd numbers.
        public static void SortArrayByParity(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            // Use two pointers to traverse from both ends.
            while (left < right)
            {
                // Increment left until an odd number is found.
                while (left < right && nums[left] % 2 == 0)
                    left++;
                // Decrement right until an even number is found.
                while (left < right && nums[right] % 2 != 0)
                    right--;
                // Swap the numbers.
                if (left < right)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                }
            }
        }

        // ================================================================
        // Method 3: Two Sum
        // ---------------------------------------------------------------
        // Given an array and a target, this method returns the indices of two numbers whose sum equals the target.
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            // Iterate through the array.
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                // If the complement exists in the dictionary, return its index and the current index.
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                // Otherwise, add the current number and its index to the dictionary.
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            // If no valid pair is found, return an empty array.
            return new int[0];
        }

        // ================================================================
        // Method 4: Find Maximum Product of Three Numbers
        // ---------------------------------------------------------------
        // This method finds three numbers in the array whose product is maximum.
        // It considers both positive and negative numbers.
        public static int MaximumProductOfThreeNumbers(int[] nums)
        {
            if (nums.Length < 3)
                throw new ArgumentException("Array must contain at least three numbers.");

            // Sort the array.
            Array.Sort(nums);
            int n = nums.Length;
            // Option 1: Product of the three largest numbers.
            int product1 = nums[n - 1] * nums[n - 2] * nums[n - 3];
            // Option 2: Product of the two smallest numbers (could be negative) and the largest number.
            int product2 = nums[0] * nums[1] * nums[n - 1];
            return Math.Max(product1, product2);
        }

        // ================================================================
        // Method 5: Decimal to Binary Conversion
        // ---------------------------------------------------------------
        // Converts a given decimal number to its binary representation.
        public static string DecimalToBinary(int number)
        {
            // Special case: if number is 0, return "0".
            if (number == 0)
                return "0";

            string binary = "";
            // Divide the number by 2 until it becomes 0, prepending each remainder.
            while (number > 0)
            {
                binary = (number % 2).ToString() + binary;
                number /= 2;
            }
            return binary;
        }

        // ================================================================
        // Method 6: Find Minimum in Rotated Sorted Array
        // ---------------------------------------------------------------
        // Uses a modified binary search to find the minimum element in a rotated sorted array.
        public static int FindMinInRotatedSortedArray(int[] nums)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                // If the mid element is greater than the right element,
                // the smallest element is in the right half.
                if (nums[mid] > nums[right])
                    left = mid + 1;
                else
                    right = mid;
            }
            return nums[left];
        }

        // ================================================================
        // Method 7: Palindrome Number Check
        // ---------------------------------------------------------------
        // Checks if an integer is a palindrome by reversing it and comparing with the original.
        public static bool IsPalindrome(int x)
        {
            // Negative numbers are not palindromes.
            if (x < 0)
                return false;

            int original = x, reversed = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                reversed = reversed * 10 + pop;
            }
            return original == reversed;
        }

        // ================================================================
        // Method 8: Fibonacci Number Calculation
        // ---------------------------------------------------------------
        // Computes the nth Fibonacci number using an iterative approach.
        public static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
