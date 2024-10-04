## For Döngüsü Konsol Uygulaması

# Genel Özellikler
Bu proje, C# dilinde for döngüsü kullanılarak yazılmış bir örnek uygulamadır. Proje, bir dizi işlevi gerçekleştirmek üzere döngü yapılarını gösterir ve Visual Studio 17 ile oluşturulmuştur.

# Proje İçeriği
* For Döngüsü Kullanımı: Bir dizi tekrarlı işlemi gerçekleştirmek için for döngüsü kullanılır.
* Debug ve Release Yapıları: Proje, Debug ve Release yapılandırmalarıyla çalıştırılabilir.

# Geliştirme Ortamı
* Visual Studio Sürümü: 17.11.35312.102
* .NET Framework: Proje, .NET 5.0 veya daha üstü bir sürümde çalıştırılabilir.

# Kod İçeriği
```csharp
for (int i = 1; i<=10; i++) 
{
    Console.WriteLine(i + "-Kendime inanıyorum, ben bu yazılım işini hallederim!");
}
```
Bu kod ile koşul 10'dan küçük veya eşit olana dek devam etmektedir. 1'den başlayarak 10 defa ekrana ''Kendime inanıyorum, ben bu yazılım işini hallederim!'' yazılmaktadır.  

```csharp
for (int i = 1; i<21; i++) 
{
    Console.WriteLine(i);
}
```
1'den 20'ye kadar sayıları ekrana yazdırmaktadır. Koşul 21'den küçük olması ile belirlenmiştir.
```csharp
for (int i = 2 ;i<20; i+=2)
{
    Console.WriteLine(i);
}
```
Sadece çift sayıları göstermektedir. Koşul değişkeni 2'şer olarak arttırılmaktadır.
```csharp
int toplam = 0; 
for (int i = 50 ;i<150; i++) 
{
    toplam = toplam + i;
}

Console.WriteLine("50 ile 150 arasindaki sayilarin toplami = " + toplam);
```
Ekrana 50'den 150'ye kadar olan sayıların toplamını yazmaktadır. toplam değişkeni her seferinde 1 arttrılmış olan koşul değişkeni ile toplanarak döngüden çıkınca toplam değeri vermektedir. 
```csharp
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
```
Bu kodda hem for döngüsü hem if statement kullanılmıştır. Sayı çift ise döngüde çift sayıların toplamına eklenir tek ise tek sayıların toplamına eklenmektedir. 
Son olarak da bu sayıların toplamını ayrı ayrı ekrana yazmaktadır. 

# Örnek Çıktı
```csharp
1-Kendime inanıyorum, ben bu yazılım işini hallederim!
2-Kendime inanıyorum, ben bu yazılım işini hallederim!
3-Kendime inanıyorum, ben bu yazılım işini hallederim!
4-Kendime inanıyorum, ben bu yazılım işini hallederim!
5-Kendime inanıyorum, ben bu yazılım işini hallederim!
6-Kendime inanıyorum, ben bu yazılım işini hallederim!
7-Kendime inanıyorum, ben bu yazılım işini hallederim!
8-Kendime inanıyorum, ben bu yazılım işini hallederim!
9-Kendime inanıyorum, ben bu yazılım işini hallederim!
10-Kendime inanıyorum, ben bu yazılım işini hallederim!
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
2
4
6
8
10
12
14
16
18
50 ile 150 arasindaki sayilarin toplami = 9950
1 ve 120 arasindaki tek sayilarin toplami = 3600
1 ve 120 arasindaki cift sayilarin toplami = 3540
```
