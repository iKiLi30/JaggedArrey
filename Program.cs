namespace JaggedArrey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] jaggedArray;

            //jaggedArray = new int[2][];
            //jaggedArray[0] = new int[2];
            //jaggedArray[1] = new int[5];
            int[][] jaggedArray = { new int[] { 1, 3, 7 }, new int[] { 2, 5, 7 }, new int[] { 4, 6, 8 } };

            foreach (int[] i in jaggedArray)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
