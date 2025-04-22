using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] sayilar = { 13, 99, 31, 42, 85};
        int[] sayilar2= new int[7];

        Random random = new Random();

        for (int i = 0; i < sayilar2.Length; i++)
        {
            sayilar2[i]=random.Next(90,99);
            Console.WriteLine(sayilar2[i]);
        }

        Console.WriteLine("-----------------------------");

        for (int i = sayilar.Length-1; i >= 0 ; i--)
        {
           
            Console.WriteLine(sayilar[i]);
        }

        Console.WriteLine("-----------------------------");

        int[] sayilar3 = new int[5];

        for (int i = 0; i < sayilar3.Length; i++)
        {
            sayilar3[i] = random.Next(1,100);
            

            if (sayilar3[i]%2 == 0)
            {
                Console.WriteLine(sayilar3[i]+" "+"Çifttir");
            }
            else
            {
                Console.WriteLine(sayilar3[i]+" "+"Tektir");
            }
        }

        Console.WriteLine("-----------------------------");

        double[] sayilar10 = new double[10];
        double toplam = 0;

        for (int i = 0; i < sayilar10.Length; i++)
        {
            Console.WriteLine((i+1)+" .sayıyı giriniz = ");

            sayilar10[i] = Convert.ToDouble(Console.ReadLine());
            toplam += sayilar10[i];

        }
        Console.WriteLine("Sayilarin ortalaması" + (toplam / 10));

        Console.WriteLine("-----------------------------");
    }
}