namespace Po1450_Klikacka.Models
{
	public class Grafika
	{
		public Grafika()
		{
			NaplnPole(radek: 6,sloupcu: 8, maxCislo: 1);
		}
		public Grafika(int radek, int sloupcu, byte pocetBarev = 4)
		{
			PripravBarvy(pocetBarev);
			NaplnPole(radek: radek, sloupcu: sloupcu, maxCislo: pocetBarev);

			zvolenaBarva = 3;
			BarvaSeznam[zvolenaBarva].Selected = true;
		}
		public Bunka[,] Pole { get; set; }
		public List<BunkaBarva> BarvaSeznam { get; set; } = new List<BunkaBarva>();

		private byte zvolenaBarva = 2;

		private void PripravBarvy(byte pocetBarev)
		{
			BarvaSeznam.Clear();
			for (byte i = 0; i <= pocetBarev; i++)
			{
				BarvaSeznam.Add(new BunkaBarva(i));
			}
		}
		private void NaplnPole(int radek, int sloupcu, byte maxCislo)
		{
			Pole = new Bunka[radek, sloupcu];
			for (int i = 0; i < radek; i++)
			{
				for (int j = 0; j < sloupcu; j++)
				{
					Pole[i, j] = new Bunka(Global.NahodneCislo(0,maxCislo),i,j);
				}
			}

		}

		public void OnClickCell(Bunka bunka, bool vybarvyVse = false)
		{
			if (vybarvyVse)
			{
				bunka.StyleClassIndex = zvolenaBarva;
				return;
			}

			if (bunka.Hodnota == 0 && bunka.StyleClassIndex != zvolenaBarva)
			{
				bunka.StyleClassIndex = zvolenaBarva;
			}
			else
			{
				bunka.StyleClassIndex = 0;
			}
		}
		public void OnClickCell(BunkaBarva bunka)
		{
			zvolenaBarva = bunka.Hodnota;
			foreach (var barva in BarvaSeznam)
			{
				barva.Selected = false;
			}
			bunka.Selected = true;
		}
	}
}
