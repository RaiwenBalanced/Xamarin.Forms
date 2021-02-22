using System;
using Foundation;
using Xamarin.Platform;

namespace Xamarin.Forms.Platform.iOS
{
	public class CheckBoxRenderer : CheckBoxRendererBase<FormsCheckBox>
	{
		[Preserve(Conditional = true)]
		public CheckBoxRenderer()
		{
		}

		[PortHandler]
        protected override FormsCheckBox CreateNativeControl()
        {
            return new FormsCheckBox();
        }

    }
}
