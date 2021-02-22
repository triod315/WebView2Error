using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WpfLibrary.TestWindow testWindow = null;
            Thread thread = new Thread(()=> {
                testWindow = new WpfLibrary.TestWindow();
                testWindow.TryInitWebView2();
                testWindow.ShowDialog();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}
