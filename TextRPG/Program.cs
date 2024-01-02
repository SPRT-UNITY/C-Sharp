using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TextRPG
{
    internal class Program
    {
        #region Console
        
        // Import the necessary functions from user32.dll
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        #endregion

        static void Main(string[] args)
        {
            IntPtr consoleWindowHandle = GetForegroundWindow();
            // Maximize the console window
            ShowWindow(consoleWindowHandle, 3);
            // Get the screen size
            Thread.Sleep(500);
            System.Console.CursorVisible = false;

            Game game = new Game();
            game.StartGame();
        }
    }

    public class Game
    {
        public const int UPPER_POSITION = 0;
        public const int MIDDLE_POSITION = 5;
        public const int LOWER_POSITION = 35;

        public static Game game;
        bool exit = false;

        List<string> messages = new List<string>();
        List<(Action, string)> decisions = new List<(Action, string)>();


        Map map = null;
        public Player defaultPlayer { get; private set; }

        public Game() 
        {
            game = this;

            messages.Add("Meeeeeesssaaaaaage");
            messages.Add("English");
            messages.Add("야호");
            messages.Add("법dfdf규");
            messages.Add("ww빠큐");
        }

        public void StartGame()
        {
            initGame();
            while (!exit) 
            {
                int input = ProcessInput();
                ProcessGameLogic(input);
                ProcessRender();
            }
        }

        public void initGame() 
        {
            ProcessRender();
            // Data Initialize
            Console.ReadLine();
            map = new Field();
            defaultPlayer = new Player();
        }

        public int ProcessInput() 
        {

            return 0;
        }

        public void ProcessGameLogic(int input) 
        { 
            
        }

        void ProcessRender() 
        {
            Console.Clear();
            RenderUpperArea();
            RenderMiddleArea();
            RenderLowerArea();
        }

        #region Render
        void RenderUpperArea() 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(0, UPPER_POSITION);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
            }
            Console.SetCursorPosition(0, UPPER_POSITION + MIDDLE_POSITION / 2);
            PrintStringCenter("SPARTA TEXT RPG");

            Console.SetCursorPosition(0, MIDDLE_POSITION - 1);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
            }
            Console.ResetColor();
        }

        void RenderMiddleArea() 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, MIDDLE_POSITION);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
            }
            
            // print messages
            for(int i=0; i< messages.Count; i++) 
            {
                Console.SetCursorPosition(0, MIDDLE_POSITION + 2 + i);
                PrintStringCenter(messages[i]);
            }

            Console.SetCursorPosition(0, LOWER_POSITION - 1);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
            }
            Console.ResetColor();
        }

        void RenderLowerArea() 
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(0, LOWER_POSITION);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
            }

            Console.SetCursorPosition(0, LOWER_POSITION + 1);
            PrintStringCenter("<< Behavior List >>");

            // print decisions
            for (int i = 0; i < decisions.Count; i++)
            {
                Console.SetCursorPosition(40, LOWER_POSITION + 3 + i);
                Console.WriteLine($"{i}. {decisions[i].Item2}");
            }

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("#");
            }

            Console.SetCursorPosition(20, Console.WindowHeight - 2);
            Console.Write("Choose one : ");
            Console.ResetColor();
        }

        public void PrintStringCenter(string str, int top = -1)
        {
            if (top == -1) top = Console.CursorTop;
            Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2 - 1, Console.CursorTop);
            Console.WriteLine(str);
        }

        #endregion

        void EnterMap(List<string> messages, List<(Action, string)> decisions) 
        {
            
        }
    }

    public class EventManager 
    {

    }
}
