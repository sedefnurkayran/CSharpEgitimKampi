using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region FOR DÖNGÜSÜ
			//1+2+3+4+5+6
			//3+3=6+4=10+5=15+6=21

			//for(x;y;z)
			//x:baslangic
			//y:bitis
			//z:artis-azalis

			//int i;
			//for (i = 1; i <= 5; i++)
			//{

			//	Console.WriteLine("C# egitim kampi");
			//}

			//int i;
			//for (i = 1; i <= 20; i++) {
			//	Console.WriteLine(i);
			//}

			//0 ile 50 arasinda 3 e tam bolunnen sayilar
			//int i;
			//for (i=0; i<=50; i += 3)
			//{
			//	Console.WriteLine(i);
			//}


			//kullanicidan bitis degeri alarak donguyu kullanma

			//int i;

			//Console.WriteLine("Lütfen yazdirilmasini istediginiz adedi yaziniz: ");
			//int endValue= int.Parse(Console.ReadLine());

			//for (i = 1; i <= endValue; i++) {

			//	Console.WriteLine("Yasasin Cumhuriyet");
			//}

			#endregion

			#region FOR DONGUSU ILE KARAR YAPILARI 

			//1 ile 100 arasinda 5 e tam bölünen sayilari yazdir
			//int i;

			//for (i=1; i<=100; i++)

			//{

			//	if (i % 5 == 0)
			//	{
			//		Console.WriteLine(i);
			//	}

			//}


			//1 ile 10 arasindaki sayilarin toplami

			//int totalValue = 0;

			//for (int i = 1; i <= 10; i++) {

			//	totalValue += i;


			//}

			//Console.WriteLine(totalValue);

			//1 ile 20 arasindaki cift sayilarin toplami

			//int totalValue = 0;

			//for (int i = 1; i < 20; i++)
			//{
			//	if (i %2 == 0)
			//	{

			//		totalValue += i;
			//		Console.WriteLine(i);

			//	}
			//}
			//Console.WriteLine("*******");
			//Console.WriteLine(totalValue);

			//1 ile 50 arasinda 7 ye tam bölünen kac sayi oldugunu bulma

			//int count = 0;

			//for (int i = 1; i < 50; i++)
			//{
			//	if (i % 7 == 0)
			//	{

			//		count ++; //count u bir artir.


			//	}
			//}
			//Console.WriteLine(count);


			//bir bakteri her saatin sonunda kendini 2 ye bolüyor. 24 ssaatin sonunda kac bakteri olur
			//1-2-4-8-16 .. 

			//int bacterium = 1;
			//for (int i = 1; i <= 24; i++) {

			//	bacterium *= 2;

			//	Console.WriteLine(i +". Saat sonunda: " + bacterium);


			//}


			#endregion


			#region WHILE

			// While(Sart)
			//{
			//islemler
			//}




			//int i = 1;

			//while(i<=10)
			//{

			//	Console.WriteLine("Merhaba Döngüler");
			//	i++;

			//}


			//1 ile 10 arasinda 3 e tam bölünen sayilari bulma

			//int i = 1;

			//while (i<=10)
			//{
			//	if (i % 3 == 0)
			//	{
			//		Console.WriteLine(i);				
			//	}
			//	i++;
			//}

			// 1 ile 10 arasindaki sayilarin toplamini hesaplama

			//int i = 1;
			//int sum = 0;
			//while (i <= 10)
			//{
			//	sum += i;
			//	i++;
			//}
			//Console.WriteLine(sum);


			#endregion


			#region ORNEK SINAV SORUSU

			//Klavyeden girilen 3 basamakli sayinin basamaklari toplamini hesaplayan kodu yaziniz.


			//456
			//Console.WriteLine("3 basamakli bir sayi giriniz: ");
			//int number = int.Parse(Console.ReadLine());
			//int ones, tens, hundreds;
			//int sum;

			//ones = number % 10;
			//tens = (number % 100) / 10; //456 % 10 : 56 olur. 56 yi da tekrar 10 a bölersek 5.6 verir. Int verdigimiz icin 5 gelir.
			//hundreds = number / 100; //4.56 -->4 cünkü int tanimladik. Noktadan sonrakini almaz.
			
			
			
			//Console.WriteLine(ones + " " + tens + " " + hundreds);
			//sum = ones + tens + hundreds;
			//Console.WriteLine(sum);


			#endregion

			Console.Read();
		}
	}
}
