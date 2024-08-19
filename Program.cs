using System;
class Program
{
    static void Main(string[] args)
    {
        int[] arrays = new int[10];
        for (int i = 0; i < arrays.Length; i++)
        {
            Console.WriteLine($"Lutfen {0}. sayıyı giriniz: ", i + 1);
            arrays[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("Dizinin Elemanları :");
        foreach (int array in arrays)
        {
            Console.WriteLine(array);
        }


        Console.WriteLine("Lutfen yeni bir sayi giriniz: (11. Eleman)");
        int newArray = Convert.ToInt32(Console.ReadLine());

        List<int> arrayList = new List<int>(arrays);
        arrayList.Add(newArray);

        arrayList.Sort();
        arrayList.Reverse();

        Console.WriteLine("Büyükten küçüğe sıralanmış dizi: ");

        foreach (int array in arrayList)
        {
            Console.WriteLine(array);
        }
    }
}




