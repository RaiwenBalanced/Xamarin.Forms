﻿using System.Threading.Tasks;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Platform.Handlers.DeviceTests.Stubs;
using Xunit;

namespace Xamarin.Platform.Handlers.DeviceTests
{
	public partial class LabelHandlerTests
	{
		UILabel GetNativeLabel(LabelHandler labelHandler) =>
			(UILabel)labelHandler.View;

		string GetNativeText(LabelHandler labelHandler) =>
			 GetNativeLabel(labelHandler).Text;

		Color GetNativeTextColor(LabelHandler labelHandler) =>
			 GetNativeLabel(labelHandler).TextColor.ToColor();

		Task ValidateNativeBackgroundColor(ILabel label, Color color)
		{
			return InvokeOnMainThreadAsync(() =>
			{
				GetNativeLabel(CreateHandler(label)).AssertContainsColor(color);
			});
		}

		NSAttributedString GetNativeTextDecorations(LabelHandler labelHandler) =>
			GetNativeLabel(labelHandler).AttributedText;

		[Fact(DisplayName = "[LabelHandler] TextDecorations Initializes Correctly")]
		public async Task TextDecorationsInitializesCorrectly()
		{
			var xplatTextDecorations = TextDecorations.Underline;

			var labelHandler = new LabelStub()
			{
				TextDecorations = xplatTextDecorations
			};

			var values = await GetValueAsync(labelHandler, (handler) =>
			{
				return new
				{
					ViewValue = labelHandler.TextDecorations,
					NativeViewValue = GetNativeTextDecorations(handler)
				};
			});

			Assert.Equal(xplatTextDecorations, values.ViewValue);
			Assert.True(values.NativeViewValue != null);
		}
	}
}