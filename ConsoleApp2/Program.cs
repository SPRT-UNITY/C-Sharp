using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.TicTacToe();
        }
    }

    public class Game
    {
        public void MatchNum()
        {
            Random random = new Random();
            int mat = 0;
            int ans = random.Next(1, 101);
            int tryNum = 0;
            Console.WriteLine("숫자 맞추기 게임을 시작합니다. 랜덤한 숫자를 생성합니다.");
            while (mat != ans)
            {
                Console.WriteLine($"1부터 100까지의 숫자를 입력해주세요. 현재까지 시행횟수 : {tryNum++}");
                mat = int.Parse(Console.ReadLine());

                if (mat < ans)
                {
                    Console.WriteLine("조금 더 큰 수를 골라보세요.");
                }
                else if (mat > ans)
                {
                    Console.WriteLine("조금 더 작은 수를 골라보세요.");
                }
            }
            Console.WriteLine($"정답입니다! (시행횟수 : {tryNum})");
        }

        public void TicTacToe() 
        {
            Console.WriteLine("틱택토 게임을 시작합니다");
            int[,] board = new int[3,3];
            int win = 0;
            int turn = 1;
            PrintBoard(board, 3, 3);
            
            while (win == 0) 
            {
                Console.WriteLine($"플레이어 {turn}의 놓을 곳을 선택해주세요(x, y 왼쪽 위가 1,1)");
                string str = Console.ReadLine();
                int x = int.Parse(str.Split(' ')[0]);
                int y = int.Parse(str.Split(' ')[1]);

                // x, y가 유효한 값인지 검증
                if(!(x >0 && x < 4 && y > 0 && y < 4)) 
                {
                    Console.WriteLine("x 또는 y가 유효하지 않습니다!");
                    continue;
                }

                if (board[x-1, y-1] == 0)
                {
                    board[x-1, y-1] = turn;
                }
                else 
                {
                    Console.WriteLine("그곳에는 놓을 수 없습니다!");
                    continue;
                }

                PrintBoard(board, 3, 3);
                if(CheckWin(board, 3, 3) != 0) 
                {
                    win = turn;
                }
                turn = (turn % 2) + 1;
            }

            Console.WriteLine($"승리! 승자는 플레이어 {win}입니다.");
        }

        public void PrintBoard(int[,] board, int width, int height) 
        {
            for (int i = 0; i < height; i++) 
            {
                for(int j = 0; j < width; j++) 
                {
                    if (board[i,j] == 0) 
                    {
                        Console.Write("□ ");
                    }        
                    if (board[i,j] == 1)
                    {
                        Console.Write("O ");
                    }
                    if (board[i,j] == 2) 
                    {
                        Console.Write("X ");
                    }
                }
                Console.Write('\n');
            }
        }

        public int CheckWin(int[,] board, int width, int height) 
        {
            int win = 0;
            
            // 가로 체크
            for (int i = 0; i < height; i++)
            {
                win = board[i,0];
                for (int j = 0; j < width; j++)
                {
                    win = (win == board[i,j]) ? win : 0;    
                }
                if (win != 0) return win;
            }

            // 세로 체크
            for (int i = 0; i < width; i++)
            {
                win = board[i, 0];
                for (int j = 0; j < height; j++)
                {
                    win = (win == board[i, j]) ? win : 0;
                }
                if (win != 0) return win;
            }

            // 대각선 체크
            if ((board[0, 0] == board[1, 1]) && (board[1, 1] == board[2, 2]))
            {
                return board[0, 0];
            }
            else if ((board[2, 0] == board[1, 1]) && (board[1, 1] == board[0, 2])) 
            {
                return board[1, 1];
            }

            return 0;
        }
    }
}
