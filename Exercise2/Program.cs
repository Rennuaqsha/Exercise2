using System;

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
                Console.WriteLine("\nMaksimal jumlah data pada array : ");
        }
        
    }
}