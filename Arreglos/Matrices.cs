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
        public int[,] ConvertirCero(int[,]matriz)
        {
            Random rdm= new Random();
            for(int i=0; i<matriz.GetLength(0);i++)
            {
                for(int j=0; j<matriz.GetLength(1);j++)
                {
                 if(i==j)
                 {
                     matriz[i,j]=1;
                 }
                 else
                 {
                     matriz[i,j]=0;
                 }
                }
                  
            }
             return matriz;   
        }
        public int[,] Convertir0(int[,]matriz)
        {
            Random rdm= new Random();
            for(int i=0; i<matriz.GetLength(0);i++)
            {
                for(int j=0;j<matriz.GetLength(1); j++)
                {
                  if(j>i)
                  {
                      matriz[i,j]=0;
                  }
                  else
                  {
                      matriz[i,j]= rdm.Next(1,10);
                  }
                }
            }
            return matriz;
        }
        public int[,] InferiorDiagonal(int[,]matriz)
        {
            Random rdm= new Random();
            for(int i=0; i<matriz.GetLength(0);i++)
            {
                for(int j=0; j<matriz.GetLength(1);j++)
                {
                    if(i>j)
                    {
                        matriz[i,j]=0;
                    }
                    else
                    {
                        matriz[i,j]=rdm.Next(1,10);
                    }
                }
                
            }
            return matriz;
        }
        public int[,] DiagonalInversa(int[,]matriz)
        {
            Random rdm= new Random();
            for(int i=0;i<matriz.GetLength(0);i++)
            {
                for(int j=0;j<matriz.GetLength(1);j++)
                {
                    if(matriz.GetLength(1)-(i+1)==j)
                    {
                        matriz[i,j]=0;

                    }
                    else
                    {
                        matriz[i,j]=rdm.Next(1,9);
                    }
                }
                
            }
            return matriz;
        }
        public int[,] Esquinas(int[,]matriz)
        {
            Random rdm= new Random();
            for(int i=0;i<matriz.GetLength(0);i++)
            {
                for(int j=0;j<matriz.GetLength(1);j++)
                {
                    if(i==0||i==matriz.GetLength(0)-1)
                    {
                        if(j==0||j==matriz.GetLength(1)-1 )
                        {
                            matriz[i,j]=1;
                        }
                    }
                     
                }
            }
            return matriz;
        }


    }
}