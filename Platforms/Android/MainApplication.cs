using Android.App;
using Android.Runtime;

namespace MauiApp5
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override void OnCreate()
        {
#if DEBUG
            // Warn if the app is engaged in behavior that could result in
            // a nonresponsive period.
            Android.OS.StrictMode.SetThreadPolicy(new Android.OS.StrictMode.ThreadPolicy.Builder()
                .DetectAll()
                .PenaltyLog()
                .Build());
#endif
            base.OnCreate();
        }
    }
}
