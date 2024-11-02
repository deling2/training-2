using System.Runtime.Serialization.Formatters;
using training_2.models;

namespace training_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            student.FirstName = "Delaram";
            student.LastName = "Ghoosaz";
            student.FatharName = "Amir Hossein";
            student.Age = 18;
            student.Grade = 12;
            student.Score = 19;
            student.ClassNumber = 12;
            int[,] matrix1 = new int[2, 2];
            {
                matrix1[0, 0] = 1;
                matrix1[1, 0] = 2;
                matrix1[0, 1] = 3;
                matrix1[1, 1] = 4;
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matrix1[i, j] + "");
                }
                Console.WriteLine();
            }
            int[,] matrix2 = new int[2, 2];
            {
                matrix2[0, 0] = -1;
                matrix2[1, 0] = -2;
                matrix2[0, 1] = -3;
                matrix2[1, 1] = -4;
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matrix2[i, j] + "");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] multiplication = new int[2, 2];
            for ( int i = 0; i < 2; i++)
            {
                for ( int j = 0; j < 2; j++)
                {
                    multiplication[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        multiplication[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            for ( int i = 0; i < 2; i++)
            {
                for ( int j = 0; j < 2; j++)
                {
                    Console.WriteLine(multiplication[i, j] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
