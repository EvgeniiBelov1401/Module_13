namespace Exercise_13_01_05
{
    internal class Program
    {
        static bool HowToSort(int[]arr)
        {
            bool sorted=true;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i + 1] > arr[i])
                {
                    sorted = true;
                }
                else
                {
                    sorted = false;
                    break;
                }                               
            }
            if (sorted==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,5,6,7,8,9,10,56,6};

            bool sort=HowToSort(array);
            Console.WriteLine(sort);
        }
    }
}
