using System;
using Xamarin.Forms;
using Xamarin.Platform;

namespace Sample
{
	public class CheckBox : Xamarin.Forms.View, ICheck
	{
		bool _isChecked;

		public bool IsChecked
		{
			get
			{
				return _isChecked;
			}
			set
			{
				if (_isChecked == value)
					return;

				_isChecked = value;
				CheckedChanged?.Invoke(value);
			}
		}

		public Color Color { get; set; } = Color.Default;

		public Action<bool> CheckedChanged { get; set; }
	}
}