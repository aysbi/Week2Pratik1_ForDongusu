//1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

for (int i = 1; i<=10; i++) 
{
    Console.WriteLine(i + "-Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (int i = 1; i<21; i++) 
{
    Console.WriteLine(i);
}

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

for (int i = 2 ;i<20; i+=2)
{
    Console.WriteLine(i);
}

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0; 
for (int i = 50 ;i<150; i++) 
{
    toplam = toplam + i;
}

Console.WriteLine("50 ile 150 arasindaki sayilarin toplami = " + toplam);

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int toplamTek = 0;
int toplamCift = 0;

for (int i = 1 ;i<120; i++)
{
    if (i%2 == 0)
        toplamCift = toplamCift + i;
    else 
        toplamTek = toplamTek + i;
}

Console.WriteLine("1 ve 120 arasindaki tek sayilarin toplami = " + toplamTek);
Console.WriteLine("1 ve 120 arasindaki cift sayilarin toplami = " + toplamCift);

Console.ReadKey();