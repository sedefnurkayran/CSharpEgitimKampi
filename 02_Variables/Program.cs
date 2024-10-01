using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Double Degiskenler
			//double number;

			//number = 4.85;

			//Console.WriteLine(number);

			//Console.WriteLine("********Fiyat Listesi**********");
			//Console.WriteLine();
			//double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

			//applePrice = 14.85;
			//orangePrice = 20.95;
			//strawberryPrice = 45;
			//potatoPrice = 9.74;
			//tomatoPrice = 6.88;


			//Console.OutputEncoding = Encoding.UTF8;

			//Console.WriteLine("---Elma Birim Fiyati" + applePrice + "₺");
			//Console.WriteLine("---Portakal Birim Fiyati" + orangePrice + "₺");
			//Console.WriteLine("---Cilek Birim Fiyati" + strawberryPrice + "₺");
			//Console.WriteLine("---Patates Birim Fiyati" + potatoPrice + "₺");
			//Console.WriteLine("---Domates Birim Fiyati" + tomatoPrice + "₺");

			//Console.WriteLine();
			//Console.WriteLine();

			//double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

			//appleGram = 1.245;
			//orangeGram = 2.650;
			//strawberryGram = 0.750;
			//potatoGram = 4.859;
			//tomatoGram = 3.745;


			//double appleTotalPrice = applePrice * appleGram;
			//double orangeTotalPrice = orangeGram * orangePrice;
			//double strawberryTotalPrice = strawberryPrice * strawberryGram;
			//double potatoTotalPrice = potatoGram * potatoPrice;
			//double tomatoTotalPrice = tomatoGram * tomatoPrice;

			//Console.WriteLine("Alinan Ürün: Elma - Birim Fiyati: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
			//Console.WriteLine("Alinan Ürün: Portakal - Birim Fiyati: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
			//Console.WriteLine("Alinan Ürün: Cilek - Birim Fiyati: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
			//Console.WriteLine("Alinan Ürün: Patates - Birim Fiyati: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
			//Console.WriteLine("Alinan Ürün: Domates - Birim Fiyati: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

			//Console.WriteLine();

			//double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

			//Console.WriteLine("Alisveris Toplam Tutari: " + shoppingTotalPrice + " TL");

			#endregion

			#region CHAR 

			//ABCDEFGH
			//DEF..
			//TOPLANTI SAAT 20:00'DE --> her bir karaktere erismemiz gerekir. 
			//String--> " char -->' 

			//char symbol;
			//symbol = 'a';

			//Console.WriteLine(symbol);

			#endregion

			#region Klavyeden Veri Girisi String Degiskenler
			//Console.WriteLine("******CSharp Hava Yollari Yolcu Bilgiler");
			//Console.WriteLine();

			//string passengerName, passengerSurname,passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

			//Console.Write("Yolcu Adi: ");
			//passengerName = Console.ReadLine();


			//Console.Write("Yolcu Soyadi: ");
			//passengerSurname = Console.ReadLine();

			//Console.Write("Ilce Bilgisi: ");
			//passengerDistrict = Console.ReadLine();

			//Console.Write("Il Bilgisi: ");
			//passengerCity = Console.ReadLine();

			//Console.Write("Yas Bilgisi: ");
			//passengerAge = Console.ReadLine();

			//Console.Write("Id Bilgisi: ");
			//passengerIdentityNumber = Console.ReadLine();

			//Console.WriteLine();
			//Console.WriteLine("Yolcu TC Kimlik Numarasi: " + " " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " +passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);


			#endregion

			#region Klavyeden Tam Sayi Girisleri ve Dönüsümler
			//int shoesPrice, computerPrice, chairPrice, tvPrice;

			//shoesPrice = 1000;
			//computerPrice = 2000;
			//chairPrice = 5000;
			//tvPrice = 12000;

			//int shoesCount, computerCount, chairCount, tvCount;

			//Console.WriteLine("Lütfen aldiginiz ayakkabinin sayisini giriniz:");
			//shoesCount = int.Parse(Console.ReadLine());


			//Console.WriteLine("Lütfen aldiginiz bilgisayar sayisini giriniz:");
			//computerCount = int.Parse(Console.ReadLine());



			//Console.WriteLine("Lütfen aldiginiz sandalye sayisini giriniz:");
			//chairCount = int.Parse(Console.ReadLine());



			//Console.WriteLine("Lütfen aldiginiz tv sayisini giriniz:");
			//tvCount = int.Parse(Console.ReadLine());

			//int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairPrice*chairCount + tvCount*tvPrice;	
			//Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " +" "+ totalPrice);

			#endregion

			#region Klavyeden Ondalikli Sayi Islemleri 

			//double exam1, exam2, exam3, result;

			//Console.Write("1.Sinav notunuzu giriniz");
			//exam1 = double.Parse(Console.ReadLine());

			//Console.Write("2.Sinav notunuzu giriniz");
			//exam2 = double.Parse(Console.ReadLine());

			//Console.WriteLine("3.Sinav notunuzu giriniz");
			//exam3 = double.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3; 
			//Console.WriteLine();
			//Console.WriteLine("Sinav Ortalamaniz: " + result);


			#endregion


			#region Klavyeden Char Girisleri

			//char gender;

			//Console.Write("Lütfen Cinsiyet Seciniz: ");
			//gender = char.Parse(Console.ReadLine());

			//Console.WriteLine("Sectiginiz Cinsiyet" + " " + gender);

			#endregion


			Console.Read();
		}
	}
}
