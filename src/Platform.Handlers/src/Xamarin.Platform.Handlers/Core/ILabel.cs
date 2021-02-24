using Xamarin.Forms;

namespace Xamarin.Platform
{
	public interface ILabel : IView, IText
	{
		int MaxLines { get; }

		LineBreakMode LineBreakMode { get; }
	}
}