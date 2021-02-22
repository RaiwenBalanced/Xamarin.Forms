using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xunit;

namespace Xamarin.Platform.Handlers.DeviceTests
{
	public partial class CheckBoxHandlerTests
	{
		NativeCheckBox GetNativeCheckBox(CheckBoxHandler checkBoxHandler) =>
			(NativeCheckBox)checkBoxHandler.View;

		bool GetNativeIsChecked(CheckBoxHandler checkBoxHandler) =>
			GetNativeCheckBox(checkBoxHandler).IsChecked;

		async Task ValidateColor(ICheck checkBoxStub, Color color, Action action = null)
		{
			var expected = await GetValueAsync(checkBoxStub, handler =>
			{
				var native = GetNativeCheckBox(handler);
				action?.Invoke();
				return native.CheckBoxTintColor;
			});
			Assert.Equal(expected, color);
		}
	}
}