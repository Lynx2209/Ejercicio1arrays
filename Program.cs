namespace Ejercici1array

{
    class program
    {
        public static void Main(String[] args)
        {
            char[] VocalesUno = { 'a', 'e', 'i', 'o', 'u' };
            char[] VocalesDos = { 'a', 'e', 'i', 'o', 'x' };

            for (int recorrido = 0; recorrido < 5; recorrido++)
            {
                if (VocalesUno[recorrido] != VocalesDos[recorrido])
                {
                    Console.WriteLine("En la posicion: " + recorrido + " del segundo array esta mal");
                }
            }
        }
    }
}