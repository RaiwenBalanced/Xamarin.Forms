﻿using Xamarin.Forms;

namespace Xamarin.Platform.Handlers.DeviceTests.Stubs
{
	public partial class LabelStub : StubBase, ILabel
	{
		public string Text { get; set; }

		public Color TextColor { get; set; }

		public FontAttributes FontAttributes { get; set; }

		public string FontFamily { get; set; }

		public double FontSize { get; set; }

		public TextDecorations TextDecorations { get; set; }
	}
}