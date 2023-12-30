namespace VjezbeCS
{
    internal class V01CiklicnaMatrica
    {
        public static void Izvedi()
        {
            Console.Write("Unesi broj redova: ");
            int red = int.Parse(Console.ReadLine());
            
            Console.Write("Unesi broj stupaca: ");
            int stup = int.Parse(Console.ReadLine());

            int b = 1;
            
            int[,] Matrica = new int[red,stup];


            //Matrica[red-1,stup-1] = 1;
            
            //for(int i = 0; i < red ; i++) 
            //{
            //    for (int j = 0; j < stup; j++)
            //    {
            //        Console.Write((Matrica[i,j]) + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("*****************************************************************");
            //Matrica[red - 1, stup - 2] = 2;

            //for (int i = 0; i < red; i++)
            //{
            //    for (int j = 0; j < stup; j++)
            //    {
            //        Console.Write(Matrica[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("*****************************************************************");
            //Matrica[red - 1, stup - 1] = 1;
            //Matrica[red - 1, stup - 2] = 2;
            //Matrica[red - 1, stup - 3] = 3;
            //Matrica[red - 1, stup - 4] = 4;
            //Matrica[red - 1, stup - 5] = 5;

            for (int i = 1; i <= stup; i++)
            {
                Matrica[red - 1, stup - i] = b++;
            }

            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stup; j++)
                {
                    Console.Write(Matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*****************************************************************");
            //Matrica[red - 2, 0] = b++;
            //Matrica[red - 3, 0] = b++;
            //Matrica[red - 4, 0] = b++;
            //Matrica[red - 5, 0] = b++;

            for (int i = 2; i <= red; i++)
            {
                Matrica[red-i, 0] = b++;
            }

            for (int i=0; i<red; i++)
            {
                for (int j=0; j<stup; j++)
                {
                    Console.Write(Matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*****************************************************************");
            //Matrica[0, 1] = b++;
            //Matrica[0, 2] = b++;
            //Matrica[0, 3] = b++;
            //Matrica[0, 4] = b++;

            for (int i = 1; i < stup; i++)
            {
                Matrica[0,i] = b++;
            }

            for (int i=0; i < red; i++)
            {
                for (int j = 0; j < stup; j++)
                {
                    Console.Write(Matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*****************************************************************");
            //Matrica[1,stup-1] = b++;
            //Matrica[2,stup-1] = b++;
            //Matrica[3,stup-1] = b++;

            for (int i = 1; i < red-1; i++)
            {
                Matrica[i, stup-1] = b++;
            }

            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stup; j++)
                {
                    Console.Write(Matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
