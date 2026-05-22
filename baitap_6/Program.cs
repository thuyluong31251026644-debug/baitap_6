
namespace baitap_6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 45, 55, 78, 34, 1, 67, 86, 46, 5, 10 };

            double tb = avg(arr);

            int x = 45;
            int y = 1;

            Console.WriteLine("mang co chua x khong: " + kiemtra(arr, x));
            Console.WriteLine("Trung binh gia tri: " + tb);
            Console.WriteLine("vi tri cua x trong mang: " + findindex(arr, y));
            // 4. remove element
            int removeValue = 45;
            int[] newArr = removeElement(arr, removeValue);

            Console.WriteLine("Array after removing element:");
            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // 5. max and min
            Console.WriteLine("Maximum value: " + findMax(arr));
            Console.WriteLine("Minimum value: " + findMin(arr));

            // 6. reverse array
            reverseArray(arr);

            Console.WriteLine("Reversed array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // 7. duplicate values
            Console.WriteLine("Duplicate values:");
            findDuplicate(arr);

            // 8. remove duplicates
            int[] uniqueArr = removeDuplicate(arr);

            Console.WriteLine("Array after removing duplicates:");
            foreach (int i in uniqueArr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        // 1. calculate average
        static double avg(int[] arr)
        {
            double sum = 0;

            foreach (int i in arr)
                sum += i;

            return sum / arr.Length;
        }

        // 2. check if array contains value
        static bool kiemtra(int[] arr, int x)
        {
            foreach (int i in arr)
            {
                if (i == x)
                {
                    return true;
                }
            }

            return false;
        }

        // 3. find index
        static int findindex(int[] arr, int y)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == y)
                {
                    return i;
                }
            }

            return -1;
        }

        // 4. remove specific element
        static int[] removeElement(int[] arr, int value)
        {
            int count = 0;

            foreach (int i in arr)
            {
                if (i != value)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            foreach (int i in arr)
            {
                if (i != value)
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }

        // 5. maximum value
        static int findMax(int[] arr)
        {
            int max = arr[0];

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }

            return max;
        }

        // 5. minimum value
        static int findMin(int[] arr)
        {
            int min = arr[0];

            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            return min;
        }

        // 6. reverse array
        static void reverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

        // 7. find duplicates
        static void findDuplicate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                    }
                }

                if (isDuplicate)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        // 8. remove duplicates
        static int[] removeDuplicate(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool duplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicate = true;
                    }
                }

                if (!duplicate)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool duplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicate = true;
                    }
                }

                if (!duplicate)
                {
                    result[index] = arr[i];
                    index++;
                }
            }

            return result;
        }

        // Bubble Sort
        static void bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Linear Search
        static bool linearSearch(string sentence, string word)
        {
            string[] words = sentence.Split(' ');

            foreach (string w in words)
            {
                if (w.ToLower() == word.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }
}

