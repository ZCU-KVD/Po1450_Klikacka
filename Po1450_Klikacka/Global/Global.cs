namespace Po1450_Klikacka
{
	public static class Global
	{
		private static Random rnd = new Random();
		public static byte NahodneCislo(byte minCislo, byte maxCislo)
		{
			return (byte)rnd.Next(minCislo, maxCislo+1);
			//return (byte)Math.Floor(rnd.NextDouble() * (maxCislo - minCislo + 1) + minCislo);
		}
	}
}
