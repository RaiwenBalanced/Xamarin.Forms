using Xamarin.Forms;

namespace Xamarin.Platform
{
	public interface ICheck : IView
	{
		bool IsChecked { get; set; }
		Color Color { get; }
	}
}