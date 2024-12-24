using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a theme: 1 - Dark, 2 - Light");
            string choice = Console.ReadLine();

            IThemeFactory factory;

            if (choice == "1")
            {
                factory = new DarkThemeFactory();
            }
            else
            {
                factory = new LightThemeFactory();
            }

            IButton button = factory.CreateButton();
            IWindow window = factory.CreateWindow();

            Console.WriteLine("Window is created: " + window.GetWindow());
            Console.WriteLine("Button is created: " + button.GetButton());
        }
        public interface IButton
        {
            string GetButton();
        }

        public interface IWindow
        {
            string GetWindow();
        }

        public class DarkButton : IButton
        {
            public string GetButton() => "Dark Button.";
        }

        public class DarkWindow : IWindow
        {
            public string GetWindow() => "Dark Window.";
        }

        public class LightButton : IButton
        {
            public string GetButton() => "Light Button.";
        }

        public class LightWindow : IWindow
        {
            public string GetWindow() => "Light Button.";
        }

        public interface IThemeFactory
        {
            IButton CreateButton();
            IWindow CreateWindow();
        }

        public class  DarkThemeFactory : IThemeFactory
        {
            public IButton CreateButton() => new DarkButton();
            public IWindow CreateWindow() => new DarkWindow();
        }

        public class LightThemeFactory : IThemeFactory
        {
            public IButton CreateButton() => new LightButton();
            public IWindow CreateWindow() => new LightWindow();
        }
    }
}
