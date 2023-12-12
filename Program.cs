namespace Ejercici1array

{
    class program
    {
        public static void Main(String[] args)
        {
            char[] VocalesUno = { 'a', 'e', 'i', 'o', 'u' };
            
            
            char[] VocalesDos = { 'a', 'e', 'i', 'o', 'x' };

            for (int i = 0; i < 1; i++)
            {
                
                for (int j = 0; j < 5; j++)
                {
                    
                    if (VocalesUno[j] != VocalesDos[j])
                    {
                       
                        Console.WriteLine(" El fallo se encuentra en la fila: " + i+ " / columna: " + j);
                    }

                }

            }
        }
    }
}