using System;
using SFML.Graphics;
using System.Collections.Generic;
using SFML.Window;
using SFML.System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares
{
    public class Program
    {
        static RenderWindow window;
        public static void Main(string[] args)
        {
            window = new RenderWindow(new VideoMode(800, 600), "Game");
            window.Closed += Window_Closed;
            window.SetFramerateLimit(60);

            Game game = new Game();

            while (window.IsOpen == true)
            {
                window.Clear(new Color(230, 230, 230));
                window.DispatchEvents();

                game.Update(window);

                window.Display();
            }
        }

        private static void Window_Closed(object sender, EventArgs e)
        {
            window.Close();
        }
    }
}
