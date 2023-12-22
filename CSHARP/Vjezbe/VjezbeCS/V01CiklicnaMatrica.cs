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
            
            int[,] Matrica = new int[red,stup];
            
            for(int i = 0; i < red; i++) 
            {
                for (int j = 0; j < stup; j++)
                {
                    Console.Write(Matrica[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*****************************************************************");
            Matrica[red - 1, stup - 1] = 1;

            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stup; j++)
                {
                    Console.Write(Matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*****************************************************************");
            Matrica[red - 1, stup - 2] = 2;
            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < stup; j++)
                {
                    Console.Write(Matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*****************************************************************");


        }
    }
}
