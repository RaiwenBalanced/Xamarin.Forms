namespace Xamarin.Platform
{
	public static class UnitExtensions
	{
		public static float EmCoefficient = 0.0624f;

		public static float ToEm(this double pt)
		{
			return (float)pt * EmCoefficient; //Coefficient for converting Pt to Em
		}
	}
}