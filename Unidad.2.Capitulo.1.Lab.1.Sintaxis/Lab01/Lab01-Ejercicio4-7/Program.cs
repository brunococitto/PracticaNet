using System;

namespace Lab01_Ejercicio4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 200;
            for (int i = 2; i <= N; i++)
            {
                bool primo_i = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        primo_i = false;
                        break;
                    }
                }
                bool primo_i_siguiente = true;
                for (int j = 2; j <= (i + 2) / 2; j++)
                {
                    if ((i + 2) % j == 0)
                    {
                        primo_i_siguiente = false;
                        break;
                    }
                }
                // Console.WriteLine($"primo_i: {primo_i} // primo_i_siguiente: {primo_i_siguiente}");
                if (primo_i == true & primo_i_siguiente == true)
                {
                    Console.WriteLine($"Los números {i} y {i + 2} son primos gemelos");
                }
            }
        }
    }
}
