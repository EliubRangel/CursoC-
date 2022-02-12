using System;
namespace Arreglos
{
    public class FundamentosArray
    {
        public static int[] LlenarArray (int Size)
        {
            int [ ] arr= new int [Size];
            // se puso size-1, por que la cajonera se recorre por que empieza en 0.
            for (int i=0;i<=Size-1;i++)
            {
                arr[i]=int.Parse (Console.ReadLine());
            }
            return arr;
        }
    }
}