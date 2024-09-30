using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjeccts
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region YAZDIRMA KOMUTLARI

			//Console.Write("Merhaba Dünya");//Imleci metinin en sagina atar.
			//Console.WriteLine("Selam");//Imleci bir alt satira kaydirir.

			//Console.WriteLine("***** Yemek Kategorileri *****");
			//Console.WriteLine();
			//Console.WriteLine("1-Corbalar");
			//Console.WriteLine("2-Ana Yemekler");
			//Console.WriteLine("3-Soguk Baslangiclar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-Tatlilar");
			//Console.WriteLine("6-Icecekler");
			//Console.WriteLine();
			//Console.WriteLine("***** Yemek Kategorileri *****");
			#endregion


			#region String Degiskenler
			//string
			//degisken_türü degisken_adi;

			//string name;
			//name = "Sedef";
			//Console.WriteLine(name);

			//string customerName;
			//string customerSurname;
			//string customerPhone;
			//string customerEmail, district, city; //ayni satirda ayni türde birden fazla degisken tanimlayabiliriz.

			//customerName = "Ali";
			//customerSurname = "Cinar";
			//customerPhone = "+90 536 136 02 01";
			//customerEmail = "deneme@gmail.com";
			//district = "Kadiköy";
			//city = "Istanbul";

			//Console.WriteLine("***** Rezervasyon Karti");
			//Console.WriteLine();
			//Console.WriteLine("-------------------------");
			//Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("Iletisim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres: " + district + "/" + city);
			//Console.WriteLine("-------------------------");


			//customerName = "Aysegül";
			//customerSurname = "Kaya";
			//customerPhone = "+90 538 166 33 71";
			//customerEmail = "test@gmail.com";
			//district = "Sapanca";
			//city = "Sakarya";

			//Console.WriteLine();
			//Console.WriteLine("-------------------------");
			//Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("Iletisim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres: " + district + "/" + city);
			//Console.WriteLine("-------------------------");
			#endregion

			#region Int Degiskenler
			//int 

			//int number = 24;
			//Console.WriteLine(number);

			int hamburgerPrice = 300;
			int cokePrice = 35;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 250;
			int lemonadePrice = 30;

			Console.WriteLine("*******Restoran Menü Fiyati********");
			Console.WriteLine("---Hamburger:" + hamburgerPrice + "TL");
			Console.WriteLine("---Coke:" + cokePrice + "TL");
			Console.WriteLine("---Water:" + waterPrice + "TL");
			Console.WriteLine("---Fries:" + friesPrice + "TL");
			Console.WriteLine("---Pizza:" + pizzaPrice + "TL");
			Console.WriteLine("---Lemonade:" + lemonadePrice + "TL");
			Console.WriteLine();
			Console.WriteLine("*******Restoran Menü Fiyati********");
			Console.WriteLine();

			int totalHamburgerPrice;
			int totalCokePrice;
			int totalWaterPrice;
			int totalFriesPrice;
			int totalPizzaPrice;
			int totalLemonadePrice;
			int totalPrice;

			int hamburgerCount;
			int cokeCount;
			int waterCount;
			int friesCount;
			int pizzaCount;
			int lemonadeCount;

			hamburgerCount = 3;
			cokeCount = 3;
			waterCount = 3;
			friesCount = 1;
			pizzaCount = 0;
			lemonadeCount = 0;

			totalHamburgerPrice = hamburgerCount * hamburgerPrice;
			totalCokePrice = cokeCount * cokePrice;
			totalWaterPrice = waterCount * waterPrice;
			totalFriesPrice = friesCount * friesPrice;
			totalLemonadePrice = lemonadeCount * lemonadePrice;
			totalPizzaPrice= pizzaCount * pizzaPrice;

			totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;

			Console.WriteLine("-------------------------");
			Console.WriteLine("Total Hamburger Price:" + totalHamburgerPrice + "TL");
			Console.WriteLine("Total Coke Price:" + totalCokePrice + "TL");
			Console.WriteLine("Total Water Price:" + totalWaterPrice + "TL");
			Console.WriteLine("Total Fries Price:" + totalFriesPrice + "TL");
			Console.WriteLine("Total Lemonade Price:" + totalLemonadePrice + "TL");
			Console.WriteLine("Total Pizza Price:" + totalPizzaPrice + "TL");

			Console.WriteLine("-----------------");
			Console.WriteLine("Total Price: "+ totalPrice + "TL");

			#endregion
			Console.Read(); //Enter a basana kadar console u acik tuttu.
		}
	}
}
