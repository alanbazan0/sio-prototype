using AppKit;

namespace SIO.Mac
{
    static class MainClass
    {
        static void Main(string[] args)
        {
			//NSApplication.Init();
			//NSApplication.Main(args);
			NSApplication.Init();
			NSApplication.SharedApplication.Delegate = new AppDelegate(); // add this line
			NSApplication.Main(args);
        }
    }
}
