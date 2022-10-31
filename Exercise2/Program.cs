using System;


namespace Exercise2
{
    class proram
    {
        //mendeklarasikan array int dengan ukuran 66
        private int[] rennu = new int[66];
        private int n;

        public void inputData()
        {
            while (true)
            {
                Console.Write("masukkan jumlah data pada array: ");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n < 66)
                    break;
                else
                    Console.WriteLine("\nMaksimal jumlah data pada array adalah 66. \n");
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("$masukkan elemen array: ");
                string s2 = Console.ReadLine();
                rennu[i] = int.Parse(s2);
            }
        }
        public void displayData()
        {
            Console.WriteLine("");
            Console.WriteLine("===================================");
            Console.WriteLine("Elemen Array yang telah terususun: ");
            Console.WriteLine("===================================");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i}. {rennu[i]}");
            }
            Console.WriteLine();
        }
        public void bubbleshort()
        {
            for (int i = 0; i < n; i++)
            {
                for (int sls = 0; sls < n; sls++);
                {
                    if(rennu)
                }
            }
        }
    }

}
