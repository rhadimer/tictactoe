using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

#if DEBUG
[assembly: Android.App.Application(Debuggable=true)]
#else
[assembly: Android.App.Application(Debuggable = false)]
#endif