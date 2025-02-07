namespace OOPgyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new("A kis herceg", "Antoine de Saint-Exupéry", 1943, 2000, 100);
			Konyv konyv2 = new("Ez még készül", "Én");

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(500);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));

            Console.WriteLine("---------------------------------------");

			Film film1 = new("Titanic", "James Cameron", 195, "Romantikus", true);
			Film film2 = new("Nem tudom meg", "Én");

			Console.WriteLine(film1.ToString() + "\n" + film2.ToString());

			film1.Jatszas();
			film1.HosszNoveles(21);
			film1.MufajModositas("Romantikus, dráma");

			Console.WriteLine("\n" + film1.ToString());

            Console.WriteLine("---------------------------------------");

			Karakter karakter1 = new("Gandalf", 20, 100, 50);
			Karakter karakter2 = new("Frodo", 30);

			Console.WriteLine(karakter1.ToString() + "\n" + karakter2.ToString());

			karakter1.Tamadas(karakter2);
			karakter2.Gogyulas(20);
			karakter1.SzintLepes();

			Console.WriteLine("\n"+ karakter1.ToString() + "\n" + karakter2.ToString());

            Console.WriteLine("---------------------------------------");

			Urhajo urhajo1 = new("Millennium Falcon", 1000, 100, 50);
			Urhajo urhajo2 = new("X-Wing", 100);

			Console.WriteLine(urhajo1.ToString() + "\n" + urhajo2.ToString());

			urhajo1.Indulas();
			urhajo1.Tankolas(20);
			urhajo1.Landolas();

			Console.WriteLine("\n" + urhajo1.ToString() + "\n" + urhajo2.ToString());

            Console.WriteLine("------------------------------------------");

			KemKuldetes kuldetes1 = new("Kém", "Magyarország", 10, 70);
			KemKuldetes kuldetes2 = new("Kém", "Magyarország");

			Console.WriteLine(kuldetes1.ToString() + "\n" + kuldetes2.ToString());

			kuldetes1.KuldetesInditasa();
			kuldetes1.VeszelySzintNovel(20);
			kuldetes1.SikerEselyNovelese(20);

			Console.WriteLine("\n" + kuldetes1.ToString() + "\n" + kuldetes2.ToString());
			
        }
	}
}
