using System;
namespace Arreglos
{
    public class Matrices
    {
        public int[,] InicializarMatrizNumerica(int cntRows, int cntCols)
        {
            int[,] matriz= new int[cntRows,cntCols];
            Random rdm = new Random();
            for(int i=0; i<matriz.GetLength(0);i++)
            {
                for(int j=0; j<matriz.GetLength(1);j++)
                {
                    matriz[i,j]=rdm.Next(1, 10);
                }
            }
            return matriz;
        }
        public void ImprimirMatriz(int[,] matriz)
        {
            for(int i=0; i<matriz.GetLength(0);i++)
            {
                
                for(int j=0; j<matriz.GetLength(1);j++)
                {
                    Console.Write(matriz[i,j]+" ");
                    
                }
                Console.WriteLine("");

            }
        }
        public int[,] MultiplicarMatriz(int[,]matriz)
        {
        
            for(int i=0; i<matriz.GetLength(0);i++)
            {
                for(int j=0; j<matriz.GetLength(1);j++)
                {
                matriz[i,j]=matriz[i,j]*2;
                }

            }
            return matriz;
             
        }


    }
}