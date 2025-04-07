namespace Po1450_Klikacka.Models
{
	public class BunkaBarva : Bunka
	{
		public BunkaBarva(byte sloupec) : base(hodnota: sloupec, radek: 0, sloupec)
		{
			StyleClassIndex = sloupec;
		}

		public bool Selected { get; set; } = false;
		private string StyleClassNameSelected => Selected ? "selected" : string.Empty;
		public override string StyleClass => $"{base.StyleClass} {StyleClassNameSelected}".Trim();

	}
}
