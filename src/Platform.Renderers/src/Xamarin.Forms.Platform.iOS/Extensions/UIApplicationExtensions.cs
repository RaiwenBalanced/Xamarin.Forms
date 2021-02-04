﻿using UIKit;
using Xamarin.Platform;

namespace Xamarin.Forms.Platform.iOS
{
	[PortHandler]
	internal static class UIApplicationExtensions
	{
		public static UIWindow GetKeyWindow(this UIApplication application)
		{
#if __MOBILE__
			var windows = application.Windows;

			for (int i = 0; i < windows.Length; i++)
			{
				var window = windows[i];
				if (window.IsKeyWindow)
					return window;
			}

			return null;
#else
			return application.KeyWindow;
#endif

		}
	}
}