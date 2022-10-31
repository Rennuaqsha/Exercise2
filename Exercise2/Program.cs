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
        static void Main(string[] args)
        {
            program mylist = new program();
            int pilihanmenu;
            do
            {
                Console.WriteLine("menu Option");
                Console.WriteLine("==================");
                Console.WriteLine("1.linear search");
                Console.WriteLine("2.Binary Search");
                Console.WriteLine("3.Exit");
                Console.Write("enter your choice (1/2/3 : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine(".......................");
                        Console.WriteLine("Linear search");
                        Console.WriteLine(".......................");
                        mylist.input();
                        mylist.LinearSearch();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine(".......................");
                        Console.WriteLine("Binary search");
                        Console.WriteLine(".......................");
                        mylist.input();
                        mylist.binarySearch();
                        break;
                    case 3:

                        Console.WriteLine("Exit. ");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                //to exit from the console
                Console.WriteLine("\n\nPress Return to exit.");
                Console.ReadLine();
            } while (pilihanmenu != 3);

        }

    }
