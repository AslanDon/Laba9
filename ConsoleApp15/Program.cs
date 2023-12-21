House dom1 = new House();
dom1.adress = "street1";
dom1.floor = 2;
dom1.room_count = 5;
dom1.area = 14.5;
House dom2 = new House();
dom2.adress = "street2";
dom2.floor = 3;
dom2.room_count = 1;
dom2.area = 12;
House dom3 = new House();
dom3.adress = "street3";
dom3.floor = 4;
dom3.room_count = 2;
dom3.area = 23.5;


House[] mass = { dom1, dom2, dom3 };

Console.WriteLine("Vvedite chislo komnat:");
int room_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite etaj:");
int etaj = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite plosad:");
int plosad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Spisok kvartir c zadannim chislom komnat");

for(int i = 0;i < mass.Length; i++)
{
    if (mass[i].room_count == room_num)
    {
        Console.WriteLine($"Kvartira v massive po indexu {i}");
    }
}

Console.WriteLine("Spisok kvartir c zadannim chislom komnat i raspalojennix na zadannom etaje:");

for( int i = 0; i < mass.Length; i++)
{
    if (mass[i].room_count == room_num && mass[i].floor == etaj)
    {
        Console.WriteLine($"Kvartira v massive po indexu {i}");
    }
}

Console.WriteLine("Spisok kvartir imeyusix plosad prevosxodyasuyu zadannuyu:");

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i].area > plosad)
    {
        Console.WriteLine($"Kvartira v massive po indexu {i}");
    }
}

public class House
{
    public string adress;
    public int floor;
    public int room_count;
    public double area;
}


