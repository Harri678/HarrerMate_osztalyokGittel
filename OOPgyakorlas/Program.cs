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

		}
	}
}
