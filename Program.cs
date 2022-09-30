using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

        //Negatif ve numeric olmayan girişleri engelleyin.
        //dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        //dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
        int i = 0;
        ArrayList sayilar = new ArrayList();
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();

        while (i < 20)
        {
            i++;
            basla:
            Console.WriteLine("sayı giriniz");
            string sayi = (Console.ReadLine()); 
            bool dogrulama = int.TryParse(sayi,out i); //alınan verinin tipini kontrol etme
            if (dogrulama==true)
            {
                int n = Convert.ToInt32(sayi);
                    if (n>=1)
                    {   //asal olup olmamasına burada bakılıyor
                        sayilar.Add(n);
                        int z =2;
                        int kontrol =0;
                        while (z<n)  
                        {
                        if(n%z==0)
                            kontrol++;
                        z++;
                        }
                        if (kontrol !=0)
                        {asalOlmayanSayilar.Add(n);}
                        else{asalSayilar.Add(n);}   
                    }
                    else
                        {Console.WriteLine( "0'dan büyük bir tam sayı giriniz");
                         goto basla;}
                
            }
            else //sayı değer girilmediğinde prorgram tekrar başlar
            {
                Console.WriteLine( "0'dan büyük bir tam sayı giriniz");
                goto basla;
            }
            

        }
        if (asalSayilar.Contains(1)) //1in asal sayı kabul edilmememesinin çözümü
        {
            asalSayilar.Remove(1);
            asalOlmayanSayilar.Add(1);
        }

        Console.WriteLine("diziyi yazdırma");
        foreach (var item in sayilar)
            Console.WriteLine(item);

        Console.WriteLine("asal diziyi yazdırma");
        foreach (var asal in asalSayilar)
            Console.WriteLine(asal);

        Console.WriteLine("asal olmayan diziyi yazdırma");
        foreach (var diger in asalOlmayanSayilar)
            Console.WriteLine(diger);

        Console.WriteLine("diziyi küçükten büyüğe yazdırma");
        sayilar.Sort();
        foreach (var item in sayilar)
            Console.WriteLine(item);

        Console.WriteLine("diziyi büyükten küçüğe yazdırma");
        sayilar.Reverse();
        foreach (var item in sayilar)
            Console.WriteLine(item);

        Console.WriteLine("dizinin eleman sayısı : ");
        Console.WriteLine(sayilar.Count);

        Console.WriteLine("asal dizinin eleman sayısı : ");
        Console.WriteLine(asalSayilar.Count);

        Console.WriteLine("asal olmayan dizinin eleman sayısı : ");
        Console.WriteLine(asalOlmayanSayilar.Count);

        //dizinin toplamını ve ortalamasını yazdırma 

        int toplam = 0;

        for (int j = 0; j < sayilar.Count; j++)
        {
            toplam = Convert.ToInt32(sayilar[j]) + toplam;
        }
        Console.WriteLine("dizinin toplamı :" + toplam);
        Console.WriteLine("dizinin ortalaması :" + toplam / sayilar.Count);

    }
}