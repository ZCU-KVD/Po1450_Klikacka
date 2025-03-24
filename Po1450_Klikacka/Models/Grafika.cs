namespace Po1450_Klikacka.Models
{
	public class Grafika
	{
		public Grafika()
		{
			NaplnPole(radek: 6,sloupcu: 8, maxCislo: 1);
		}

		public Bunka[,] Pole { get; set; }
		private byte zvolenaBarva = 2;

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

		public void OnClickCell(Bunka bunka)
		{
			if (bunka.Hodnota == 0 && bunka.StyleClassIndex != zvolenaBarva)
			{
				bunka.StyleClassIndex = zvolenaBarva;
			}
			else
			{
				bunka.StyleClassIndex = 0;
			}
		}

	}
}
