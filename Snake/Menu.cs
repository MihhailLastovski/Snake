using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Snake
{
    public class Menu : RndColor
    {
        public void Main()
        {
            bool answer = false;
            Console.SetWindowSize(120, 40);
            do
            {
                Console.WriteLine(@"

 ________  ________   ________  ___  __    _______           ________  ________  _____ ______   _______      
|\   ____\|\   ___  \|\   __  \|\  \|\  \ |\  ___ \         |\   ____\|\   __  \|\   _ \  _   \|\  ___ \     
\ \  \___|\ \  \\ \  \ \  \|\  \ \  \/  /|\ \   __/|        \ \  \___|\ \  \|\  \ \  \\\__\ \  \ \   __/|    
 \ \_____  \ \  \\ \  \ \   __  \ \   ___  \ \  \_|/__       \ \  \  __\ \   __  \ \  \\|__| \  \ \  \_|/__  
  \|____|\  \ \  \\ \  \ \  \ \  \ \  \\ \  \ \  \_|\ \       \ \  \|\  \ \  \ \  \ \  \    \ \  \ \  \_|\ \ 
    ____\_\  \ \__\\ \__\ \__\ \__\ \__\\ \__\ \_______\       \ \_______\ \__\ \__\ \__\    \ \__\ \_______\
   |\_________\|__| \|__|\|__|\|__|\|__| \|__|\|_______|        \|_______|\|__|\|__|\|__|     \|__|\|_______|
   \|_________|                                                                                              
                                                                                                             
                                                                                                             
");
                Console.WriteLine(@"

           __               
 /| __ __ (_ _|_  _. ._ _|_ 
  |       __) |_ (_| |   |_ 
                            
");
                Console.WriteLine(@"
 _       ___      _    
  ) __ __ |  ._ _|_ _  
 /_      _|_ | | | (_) 
                       
");
                Console.WriteLine(@"
 _         __                                               _   _   
 _) __ __ (_   _  ._ _   _     _   _   _   _|    _ _|_    _|_ _|_ _ 
 _)       __) (_) | | | (/_   (_| (_) (_) (_|   _>  |_ |_| |   | _> 
                               _|                                   
");
                Console.WriteLine(@"
             _          
 |_|_ __ __ |_    o _|_ 
   |        |_ >< |  |_ 
                        
");
                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        answer = true;
                        Clear();
                        ShowSimplePercentage();
                        break;
                    case ConsoleKey.D2:
                        answer = true;
                        Info();
                        break;
                    case ConsoleKey.D3:
                        answer = true;
                        GoodStuffs();
                        break;
                    case ConsoleKey.D4:
                        answer = true;
                        ShowSpinner();
                        Environment.Exit(0);
                        break;

                }
                Clear();
            } while (answer!=true);
            
            void Info()
            {
                Clear();
                Console.WriteLine("Author -> Mihhail Lastovski\nGroup -> TARpv21");
                Console.ReadKey(true);
                Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Main();
            }
            void GoodStuffs()
            {
                Clear();
                Console.WriteLine(@"
 .----------------.  .----------------.  .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
| | _____  _____ | || |      __      | || |     _____    | || |  _________   | || |              | |
| ||_   _||_   _|| || |     /  \     | || |    |_   _|   | || | |  _   _  |  | || |      _       | |
| |  | | /\ | |  | || |    / /\ \    | || |      | |     | || | |_/ | | \_|  | || |     | |      | |
| |  | |/  \| |  | || |   / ____ \   | || |      | |     | || |     | |      | || |     | |      | |
| |  |   /\   |  | || | _/ /    \ \_ | || |     _| |_    | || |    _| |_     | || |     | |      | |
| |  |__/  \__|  | || ||____|  |____|| || |    |_____|   | || |   |_____|    | || |     |_|      | |
| |              | || |              | || |              | || |              | || |     (_)      | |
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 
");
                Thread.Sleep(1500);
                MultiLineAnimation();
                Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"     ____________________________________________________________________________
    |  ____                                                                      |
    | [____] [_]   [_][_][_][_] [_][_][_][_] [_][_][_][_] [_][_][_] [_][_][_][_] |
    |                                                ___                         |
    | [_][_] [§][1][2][3][4][5][6][7][8][9][0][+]['][___] [_][_][_] [_][_][_][_] |
    | [_][_] [__][q][å][ä][p][y][f][g][c][r][l][x][@][  | [_][_][_] [_][_][_][ | |
    | [_][_] [___][a][o][e][u][i][d][h][t][n][s][j][-][_|           [_][_][_][_| |
    | [_][_] [_][<]['][,][.][k][ö][b][m][w][v][z][______]    [_]    [_][_][_][ | |
    | [_][_] [__][_][__][_____________________][__][_][_] [_][_][_] [____][_][_| |
    |____________________________________________________________________________|");
                Console.WriteLine();
                Console.WriteLine(@"       _____ ___________________________________________________ _____    
      |    //       :-...__                       __...-:       \\    | 
      |   //        :  `.  ~~--._           _.--~~  .'  :        \\   | 
      |  //          :  `..._    ~~-.___.-~~    _..,'  :          \\  | 
      | //           :   : `.~-._           _.-~.' :   :           \\ |
      |//        ..-'    :  :..  ~-._   _.-~  ..:  :    `-..        \\| 
       / `.__.--'       :   `. `._   ~~~   _.' ,`   :       `--.__.' \       
      |      .`-......-'     :  `.~-._ _.-~.'  :     `-......-'.      |     
      |  __.'     `-..__ ..-'    :._  ~  _.:    `-.. __..-'     `.__  |      
      |.'  ~`.     .'   `-.._ ..' : `-.-' : `.. _..-'   `.     .'~  `.|
      | '.    `..'~~`.    .' `-._'_;.   .;_`_.-' `.    .'~~`..'    .' |    
      |  '.    `.     `.'~-..-.'_'-..:-:..-`_`.-..-~`.'     .'    .'  |    
      |   '.    `.     `,   `. `.`.;~ . ~;.',' ,'   ,'     .'    .'   |   
      |    )     )      }    }  }  }}`.'{{  {  {    {      (     (    |    
      |   .'    .'     .'   .' .'.'`-._.-``.`. `.   `.     `.    `.   |   
      |  .'    .'     .'._.-`-' ~`-.;.-.;.-'~ `-'-._,`.     `.    `.  |   
      | .'    .'`.__.'     ~`._   .`_.-._'.   _.'~     `.__,'`.    `. |      
      |.'   ..'      ~`-.      ~-.`~ _._ ~'.-~      .-'~      `..   `.|     
      | `--~  ~`-._      `-.    : .-'   `-. :    .-'      _.-'~  ~--' |      
      |            ~-.      `. .`'  _..._  `'. .'      .-~            |     
      |               `.     .' ..-'     `-.. `.     .'               |     
       \                `-. .'-'             `-`. .-'                /     
      |\\                 .'         ___         `.                 //|    
      | \\                :      .--~   ~--.      :                // |    
      |__\\_______________`.__.-~___________~-.__.'_______________//__|");

                Console.ReadKey(true);
                Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Main();
            }
            void ShowSimplePercentage()
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.ForegroundColor = GetRandomConsoleColor();
                    Console.Write($"\rProgress: {i}%   ");
                    Thread.Sleep(25);
                }

                Console.Write("\rDone!          ");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
            }
            void MultiLineAnimation()
            {
                var counter = 0;
                for (int i = 0; i < 30; i++)
                {
                    Console.Clear();

                    switch (counter % 4)
                    {
                        case 0:
                            {
                                Console.WriteLine("╔════╤╤╤╤════╗");
                                Console.WriteLine("║    │││ \\   ║");
                                Console.WriteLine("║    │││  O  ║");
                                Console.WriteLine("║    OOO     ║");
                                break;
                            };
                        case 1:
                            {
                                Console.WriteLine("╔════╤╤╤╤════╗");
                                Console.WriteLine("║    ││││    ║");
                                Console.WriteLine("║    ││││    ║");
                                Console.WriteLine("║    OOOO    ║");
                                break;
                            };
                        case 2:
                            {
                                Console.WriteLine("╔════╤╤╤╤════╗");
                                Console.WriteLine("║   / │││    ║");
                                Console.WriteLine("║  O  │││    ║");
                                Console.WriteLine("║     OOO    ║");
                                break;
                            };
                        case 3:
                            {
                                Console.WriteLine("╔════╤╤╤╤════╗");
                                Console.WriteLine("║    ││││    ║");
                                Console.WriteLine("║    ││││    ║");
                                Console.WriteLine("║    OOOO    ║");
                                break;
                            };
                    }

                    counter++;
                    Thread.Sleep(200);
                }
            }
            void ShowSpinner()
            {
                Clear();
                var counter = 0;
                for (int i = 0; i < 50; i++)
                {
                    Console.ForegroundColor = GetRandomConsoleColor();
                    switch (counter % 4)
                    {
                        case 0: Console.Write("/"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("\\"); break;
                        case 3: Console.Write("|"); break;
                    }
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    counter++;
                    Thread.Sleep(100);
                }
                Console.WriteLine(@"
 .----------------.  .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. || .--------------. |
| |   ______     | || |  ____  ____  | || |  _________   | || |              | |
| |  |_   _ \    | || | |_  _||_  _| | || | |_   ___  |  | || |      _       | |
| |    | |_) |   | || |   \ \  / /   | || |   | |_  \_|  | || |     | |      | |
| |    |  __'.   | || |    \ \/ /    | || |   |  _|  _   | || |     | |      | |
| |   _| |__) |  | || |    _|  |_    | || |  _| |___/ |  | || |     | |      | |
| |  |_______/   | || |   |______|   | || | |_________|  | || |     |_|      | |
| |              | || |              | || |              | || |     (_)      | |
| '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------' 
");
                Thread.Sleep(1500);

            }
        }

    }
}