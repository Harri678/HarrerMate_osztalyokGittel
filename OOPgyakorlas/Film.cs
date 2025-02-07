using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlas
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool mejelent;

		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Mejelent { get => mejelent; set => mejelent = value; }

		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool mejelent)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.mejelent = mejelent;
		}

		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			hosszPercekben = 120;
			mufaj = "Ismeretlen";
			mejelent = false;
		}

		public void Jatszas() 
		{ 			
			if (mejelent)
			{
				Console.WriteLine("A film megy");
			}
			else
			{
				Console.WriteLine("A film nem megy");
			}
		}

		public void MufajModositas(string ujMufaj)
		{
			mufaj = ujMufaj;
		}

		public void HosszNoveles(int percek)
		{
			hosszPercekben += percek;
		}

		public override string? ToString()
		{
			return $"Cím: {cim}, Rendező: {rendezo}, Hossz percekben: {hosszPercekben}, Műfaj: {mufaj}, Megjelenés: {mejelent}";
		}

	}
}
