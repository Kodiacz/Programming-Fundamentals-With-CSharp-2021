using System;

namespace ArrayRotation
{
    class ArrayRotation
    {
        static void Main(string[] args)
        {
            //1 2 3 4 
            //1
            
            string[] array = Console.ReadLine().Split(' ');
            int rows = int.Parse(Console.ReadLine());

            //for (int i = 0; i < rows; i++)  // Shift Left
            //{
            //    string temp = array[0];

            //    for (int k = 0; k < array.Length - 1; k++)
            //    {
            //        array[k] = array[k + 1];

            //        if (k == array.Length - 2)
            //        {
            //            array[array.Length - 1] = temp;
            //        }
            //    }
            //}

            for (int i = 0; i < rows; i++)  // Shift Right
            {
                string temp = array[array.Length - 1];

                for (int k = array.Length - 1; k > 0; k--)
                {
                    array[k] = array[k - 1];

                    if (k == 1)
                    {
                        array[0] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
