using System;
using AvalonDock.Themes;

namespace Bgoon.AvalonDockTheme {
	public class FlatDarkTheme : Theme {

		public override Uri GetResourceUri() {
				return ResourceUtility.GetUri("Bgoon.AvalonDockThemes", "Styles/FlatDark/FlatDark.xaml");
		}
	}
}
