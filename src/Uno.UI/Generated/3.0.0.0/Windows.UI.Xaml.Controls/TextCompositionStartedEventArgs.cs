#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TextCompositionStartedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int Length
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextCompositionStartedEventArgs.Length is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20TextCompositionStartedEventArgs.Length");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int StartIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TextCompositionStartedEventArgs.StartIndex is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20TextCompositionStartedEventArgs.StartIndex");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs.StartIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs.Length.get
	}
}
