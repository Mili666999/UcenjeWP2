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

            int a = 0;
            int b = 1;
            int c = 2;
            int d = 3;
            int x = 1;
            int i = 0;
            
            int[,] Matrica = new int[red,stup];
           

            //Prvi krug
            for (i=1; i<=stup; i++)
            {
                Matrica[red-1, stup-i] = x++;
            }
            for (i=2; i<=red; i++)
            {
                Matrica[red-i, 0] = x++;
            }
            for (i=1; i<stup; i++)
            {
                if (red <= 1)
                {
                    break;
                }
                Matrica[0, i] = x++;
            }
            for (i=1; i<red-1; i++)
            {
                Matrica[i, stup-1] = x++;
            }



            //Ostali krugovi
            int y = 1;
            for (y = 1; y < red && y < stup; y++)
            {
                if (red * stup == x + 1)
                {
                    break;
                }
                y++;


                for (i = c; i < stup - a; i++)
                {
                    if (red == 2 || stup == 2 || red * stup == x - 1)
                    {
                        break;
                    }
                    Matrica[red - c, stup - i] = x++;
                }

                for (i = d; i < red - a; i++)
                {
                    if (red == 2 || stup == 2 || red * stup == x - 1)
                    {
                        break;
                    }
                    Matrica[red - i, b] = x++;
                }

                for (i = c; i < stup - b; i++)
                {
                    if (red == 2 || stup == 2 || red * stup == x - 1)
                    {
                        break;
                    }
                    Matrica[b,i] = x++;
                }

                for (i = c; i < red - c; i++)
                {
                    if (red == 2 || stup == 2 || red * stup == x - 1)
                    {
                        break;
                    }
                    Matrica[i,stup - c] = x++;
                }
                a++;
                b++;
                c++;
                d++;
            }


            //Ispis matrice
            Console.WriteLine();
            for (i = 0; i < red; i++)
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
