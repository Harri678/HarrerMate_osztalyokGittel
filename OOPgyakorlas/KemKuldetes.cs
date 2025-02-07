using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPgyakorlas
{
	internal class KemKuldetes
	{
		private string kodNev;
		private string orszag;
		private int veszelySzint;
		private int sikerEsely;

		public string KodNev { get => kodNev; set => kodNev = value; }
		public string Orszag { get => orszag; set => orszag = value; }
		public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
		public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

		public KemKuldetes(string kodNev, string orszag, int veszelySzint, int sikerEsely)
		{
			this.kodNev = kodNev;
			this.orszag = orszag;
			this.veszelySzint = veszelySzint;
			this.sikerEsely = sikerEsely;
		}
		public KemKuldetes(string kodNev, string orszag)
		{
			this.kodNev = kodNev;
			this.orszag = orszag;
			veszelySzint=5;
			sikerEsely = 50;
		}

		public void KuldetesInditasa()
		{
			Console.WriteLine("A küldetés elindult!");
		}

		public void VeszelySzintNovel(int szint)
		{
			veszelySzint += szint;
		}

		public void SikerEselyNovelese(int szazalek)
		{
			sikerEsely += (int)(sikerEsely * (szazalek / 100));
		}

		public override string? ToString()
		{
			return $"Kód név: {kodNev}, Ország: {orszag}, Veszély szint: {veszelySzint}, Siker esély: {sikerEsely}";
		}
	}
}
