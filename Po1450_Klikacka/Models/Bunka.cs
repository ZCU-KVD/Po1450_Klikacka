namespace Po1450_Klikacka.Models
{
	public class Bunka
	{
		public Bunka(byte hodnota, int radek, int sloupec)
		{
			Hodnota = hodnota;
			Radek = radek;
			Sloupec = sloupec;
		}

		public byte Hodnota{ get; private set; }
		public int Radek { get;  }
		public int Sloupec { get; }
		public byte StyleClassIndex { get; set; } = 0;
		public virtual string StyleClass => $"barva-{StyleClassIndex}";
	}
}
