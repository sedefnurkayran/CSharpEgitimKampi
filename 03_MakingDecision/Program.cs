using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region IF ELSE 


			//Console.WriteLine("Lütfen sifreyi giriniz: ");

			//string password;
			//password = Console.ReadLine(); //girilen sifreyi passworde ata.

			//karar yapilarindan sonra noktali virgul konulmaz.

			//if (password == "abcd")
			//{

			//	Console.WriteLine("Sifre Dogru");
			//}
			//else {
			//	Console.WriteLine("Sifre Yanlis");			
			//}


			//2. ORNEK
			//string capital, country;

			//Console.WriteLine("Baskenti giriniz: ");
			//capital = Console.ReadLine();

			//Console.WriteLine("Ülkeyi giriniz: ");
			//country = Console.ReadLine();

			////and icin artik tek & yetiyor. If büyük kücük harf uyumlulugu var. Ankara yazarsam else düser.
			//if (capital == "ankara" & country == "türkiye")
			//{
			//	Console.WriteLine("veriler dogrulandi");

			//}
			//else 
			//{
			//	Console.WriteLine("hatali bilgi");
			//}

			//3.ORNEK SAYISAL VERILER

			//int number;

			//Console.WriteLine("Sayi giriniz: ");

			//number = int.Parse(Console.ReadLine());

			//if (number == 5)
			//{
			//	Console.WriteLine("Sayi dogrudur");

			//}
			//else {
			//	Console.WriteLine("Sayi hatalidir");

			//}

			//4. ORNEK SINAVLARIN ORTALAMASI

			//int exam1, exam2, exam3, avarage;
			//string result="Hata!";

			//Console.WriteLine("1. Sinav sonucunu giriniz: ");
			//exam1 = int.Parse(Console.ReadLine());
			//Console.WriteLine("2. Sinav sonucunu giriniz: ");
			//exam2 = int.Parse(Console.ReadLine());
			//Console.WriteLine("3. Sinav sonucunu giriniz: ");
			//exam3 = int.Parse(Console.ReadLine());


			//avarage = (exam1 + exam2 + exam3) / 3;

			//Console.WriteLine("Sinavlarin ortalamasi: " + avarage);

			//if (avarage > 0 & avarage <= 50) {

			//	Console.WriteLine("Sonuc vasat");
			//}
			//if (avarage > 50 & avarage <= 70)
			//{

			//	Console.WriteLine("Sonuc Orta");
			//}
			//if (avarage > 70 & avarage <= 84)
			//{

			//	Console.WriteLine("Sonuc Iyi");
			//}
			//if (avarage > 84)
			//{

			//	Console.WriteLine("Sonuc Cok Iyi");
			//}
			//Console.WriteLine(result); //result in bir baslangic degeri yok veya if lere girmezse result in ne olacagini soylemedik. Bu yüzden 0165 hatasi cikiyor.

			// 5. ORNEK & ve || birlikte kullanimi

			//string city;
			//Console.WriteLine("Sehir giriniz: ");
			//city = Console.ReadLine();

			//if (city == "bursa" | city == "ankara" | city == "istanbul")
			//{

			//	Console.WriteLine("Sehir mevcut");

			//}
			//else {
			//	Console.WriteLine("Sehir mevcut degil");

			//}

			//6. ORNEK - ESIT DEGILSE

			//Console.WriteLine("Kullanici adi giriniz: ");

			//string username = Console.ReadLine();

			//if(username != "admin")
			//{
			//	Console.WriteLine("kullanici adi kabul edilmedi");

			//}
			//else
			//{

			//	Console.WriteLine("Hos geldiniz");
			//}

			//7. ORNEK



			#endregion

			#region MOD ISLEMLERI

			//int number;
			//number= 26;
			//int result = number % 5;
			//Console.WriteLine(result);

			//Console.WriteLine("Lütfen 1. sayiyi giriniz: ");
			//int number1 = int.Parse(Console.ReadLine());


			//Console.WriteLine("Lütfen 2. sayiyi giriniz: ");
			//int number2 = int.Parse(Console.ReadLine());

			//int result = number1%number2;

			//Console.WriteLine("1. sayinin 2. sayiya bölümünden kalan " + result);

			//Sayi tek mi cift mi

			//Console.WriteLine("Lütfen bir sayi giriniz: ");
			//int number = int.Parse(Console.ReadLine());

			//if (number % 2 == 0)
			//{
			//	Console.WriteLine("Sayi cifttir ");


			//}
			//else
			//{
			//	Console.WriteLine("Sayi tektir");
			//}

			#endregion

			#region CHAR DEGISKENLER ILE KARAR YAPILARI
			//char degiskenine gore takim yazdirma

			//char team;
			//Console.WriteLine("Lütfen takim sembolünü giriniz");
			//team = char.Parse(Console.ReadLine());


			//if (team == 'g' | team == 'G')
			//{
			//	Console.WriteLine("Galatasaray");
			//}
			//if (team == 'f' | team == 'F')
			//{
			//	Console.WriteLine("Fenerbahce");
			//}
			//if (team == 'b' | team == 'B')
			//{
			//	Console.WriteLine("Besiktas");
			//}

			#endregion

			#region  ÖRNEK PROJE UYGULAMASI

			//Console.WriteLine("C# Egitim Kampi Restoran");
			//Console.WriteLine();
			//Console.WriteLine("--------------------------------------");
			//Console.WriteLine("1-Ana Yemekler");
			//Console.WriteLine("2-Corbalar");
			//Console.WriteLine("3-Pizzalar");
			//Console.WriteLine("4-Icecekler");
			//Console.WriteLine("5-Tatlilar");
			//Console.WriteLine("--------------------------------------");
			//Console.WriteLine();

			//string MenuItem;
			//Console.WriteLine("Detayini görmek istediginiz menü secimi:");
			//MenuItem = Console.ReadLine();

			//if (MenuItem == "1")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-----------------Ana Yemekler----------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Köri Soslu Tavuk");
			//	Console.WriteLine("2-Patlican Musakka");
			//	Console.WriteLine("3-Kuru Fasülye Pilav");
			//	Console.WriteLine("4-Kizartma Tabagi");
			//	Console.WriteLine("5-Firinda Somon");
			//}
			//if (MenuItem == "2")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-----------------Corbalar----------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Mercimek Corbasi");
			//	Console.WriteLine("2-Yogurt Corbasi");

			//}
			//if (MenuItem == "3")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-----------------Pizzalar----------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Fungi");
			//	Console.WriteLine("2-SuperMix");

			//}
			//if (MenuItem == "4")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-----------------Icecekler----------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Su");
			//	Console.WriteLine("2-Kola");

			//}
			//if (MenuItem == "5")
			//{
			//	Console.WriteLine();
			//	Console.WriteLine("-----------------Tatlilar----------------");
			//	Console.WriteLine();
			//	Console.WriteLine("1-Kazandibi");
			//	Console.WriteLine("2-Sütlü nuriye");

			//}

			#endregion

			#region SWITCH CASE

			//Console.WriteLine("Lütfen Ay Girisi Yapiniz: ");

			//int monthNumber = int.Parse(Console.ReadLine());

			//switch (monthNumber)
			//{
			//	case 1: Console.Write("Ocak");break;
			//	case 2: Console.Write("Subat"); break;
			//	case 3: Console.Write("Mart"); break;
			//	case 4: Console.Write("Nisan"); break;
			//	case 5: Console.Write("Mayis"); break;
			//	case 6: Console.Write("Haziran"); break;
			//	case 7: Console.Write("Temmuz"); break;
			//	case 8: Console.Write("Agustos"); break;
			//	case 9: Console.Write("Eylül"); break;
			//	case 10: Console.Write("Ekim"); break;
			//	case 11: Console.Write("Kasim"); break;
			//	case 12: Console.Write("Aralik"); break;
			//	default: Console.Write("Hata"); break;
			//}



			#endregion

			#region SWITCH CASE HESAP MAKINESI UYGULAMASI

			//int number1, number2, result;
			//char symbol;

			//Console.Write("1.Sayiyi giriniz:");
			//number1 = int.Parse(Console.ReadLine());

			//Console.Write("2.Sayiyi giriniz:");
			//number2 = int.Parse(Console.ReadLine());

			//Console.Write("Yapmak istediginiz islemi seciniz: ");
			//symbol = char.Parse(Console.ReadLine());

			//switch (symbol)
			//{

			//	case '+': 
			//		result = number1 + number2;
			//		Console.WriteLine("Islemin sonucu " + result);
			//		break;

			//	case '-':
			//		result = number1 - number2;
			//		Console.WriteLine("Islemin sonucu " + result);

			//		break;
			//	case '*':
			//		result = number1 * number2;
			//		Console.WriteLine("Islemin sonucu " + result); 
			//		break;

			//	case '/':	
			//		result = number1 / number2;
			//		Console.WriteLine("Islemin sonucu " + result); 
			//		break;
					

			//}

			#endregion


			Console.Read();
		}
	}
}
