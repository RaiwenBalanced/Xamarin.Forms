﻿using System;
using Xamarin.Forms;

namespace Xamarin.Platform.Handlers.DeviceTests.Stubs
{
	public partial class ButtonStub : StubBase, IButton
	{
		public string Text { get; set; }

		public Color TextColor { get; set; }

		public FontAttributes FontAttributes { get; set; }

		public string FontFamily { get; set; }

		public double FontSize { get; set; }

		public double CharacterSpacing { get; set; }

		public event EventHandler Pressed;
		public event EventHandler Released;
		public event EventHandler Clicked;

		void IButton.Pressed() => Pressed?.Invoke(this, EventArgs.Empty);
		void IButton.Released() => Released?.Invoke(this, EventArgs.Empty);
		void IButton.Clicked() => Clicked?.Invoke(this, EventArgs.Empty);
	}
}