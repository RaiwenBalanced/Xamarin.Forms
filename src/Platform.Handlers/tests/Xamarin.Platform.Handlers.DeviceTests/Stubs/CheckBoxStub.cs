using Xamarin.Forms;

namespace Xamarin.Platform.Handlers.DeviceTests.Stubs
{
	public partial class CheckBoxStub : StubBase, ICheck
	{
		public bool IsChecked { get; set; }

		public Color Color { get; set; }
	}
}