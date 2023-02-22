using System;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Program
{

    class Window : GameWindow
    {
        public Window(
            int width,
            int height,
            string title) : base(
                GameWindowSettings.Default,
                new NativeWindowSettings()
                {
                    Size = (width, height),
                    Title = title
                })
        { }

        static void Main()
        {
            using (Window window = new Window(800, 600, "LearnOpenTK"))
            {
                System.Console.WriteLine("Script Running");
                window.Run();
            }
        }

    }


}