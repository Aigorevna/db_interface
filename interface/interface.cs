﻿using Button_Selector;
using Button;

namespace Interface
{
    public class ConsoleInterface
    {
        public static void Window_Button(int x, int y)//отрисовка рамки для кнопки
        {
            int line = 3;
            int column = 15;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');

                    }
                }
                y++;
                Console.WriteLine();
                Console.SetCursorPosition(x, y);
            }

        }

        public static void Window_Main(int x, int y, int line, int column)//отрисовка окна
        {

            Console.SetCursorPosition(x, y);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');

                    }
                }
                y++;
                Console.WriteLine();
                Console.SetCursorPosition(x, y);
            }
        }

        public static void Dropdown_Menu(int x, int y)//выпадающее окно
        {
            int line = 13;
            int column = 30;
            int Y = y;
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == 0 | j == 0 | i == line - 1 | j == column - 1 | i == 4 | i == 8)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');

                    }
                }
                Y++;
                Console.WriteLine();
                Console.SetCursorPosition(x, Y);
            }
            Console.SetCursorPosition(x + 3, y + 2);
            Console.Write("Кнопка 1");
            Console.SetCursorPosition(x + 3, y + 6);
            Console.Write("Кнопка 2");
            Console.SetCursorPosition(x + 3, y + 10);
            Console.Write("Кнопка 3");

        }

        public static void LogIn_Or_LogOn(int x, int y)//регистрация или вход
        {
            var Button_LogIn = new Buttons { Method = new Action(() =>
            {
                Console.SetCursorPosition(x + 4, y + 1);
                Console.WriteLine("Log In");
            }), command = 1 };
            var Button_LogOn = new Buttons { Method = new Action(() =>
            {
                Console.SetCursorPosition(x + 4, y + 6);
                Console.WriteLine("Log On");
            }), command = 2};
            var select = new ConsoleMenu(Button_LogIn, Button_LogOn)
            {
                x = x,
                y = y
            };

            Window_Main(x - 15, y - 6, 20, 45);
            Console.SetCursorPosition(x + 1, y - 4);
            Console.Write("!!!WELCOME!!!");
            Window_Button(x, y);
            
            Window_Button(x, y + 5);
            
            select.Show();
        }

        public static void Restaurants(int x, int y)//выбор ресторана
        {
            var Button_north = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 2, y + 1);
                    Console.Write("ЧешиНаСевер");
                }),
                command = 1
            };
            var Button_south = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 3, y + 6);
                    Console.Write("ЧешиНаЮг");
                }),
                command = 2
            };
            var Button_west = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 2, y + 11);
                    Console.Write("ЧешиНаЗапад");
                }),
                command = 3
            };
            var select = new ConsoleMenu(Button_north, Button_south, Button_west)
            {
                x = x,
                y = y
            };
            Window_Main(x - 19, y - 6, 25, 55);
            Console.SetCursorPosition(x - 13, y - 3);
            Console.Write("Какой рестсоран <ЧешиНа> Вы хотите посетить?");
            Window_Button(x, y);

            Window_Button(x, y + 5);

            Window_Button(x, y + 10);

            Console.SetCursorPosition(x - 10, y + 14);
            Console.Write("<ЧешиНа> - сеть ресторанов Чешской кухни");

            select.Show();
        }

        public static void Date(int x, int y)
        {
            var Button_today = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 4, y + 1);
                    Console.Write("Сегодня");
                }),
                command = 1
            };
            var Button_tomorrow = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 4, y + 6);
                    Console.Write("Завтра");
                }),
                command = 2
            };
            var Button_day_after_tomorrow = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 2, y + 11);
                    Console.Write("Послезавтра");
                }),
                command = 3
            };
            var select = new ConsoleMenu(Button_today, Button_tomorrow, Button_day_after_tomorrow)
            {
                x = x,
                y = y
            };

            Window_Main(x - 19, y - 6, 25, 55);
            Console.SetCursorPosition(x - 14, y - 3);
            Console.Write("Выберите день, когда хотите посетить ресторан:");
            Window_Button(x, y);

            Window_Button(x, y + 5);

            Window_Button(x, y + 10);

            select.Show();
        }

        public static void Time(int x, int y)
        {
            var Button_1000_1130 = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 2, y + 1);
                    Console.Write("10:00-11:30");
                }),
                command = 1
            };
            var Button_1130_1300 = new Buttons
            {
                Method = new Action(() =>
                {

                    Console.SetCursorPosition(x + 2, y + 5);
                    Console.Write("11:30-13:00");
                }),
                command = 2
            };
            var Button_1300_1430 = new Buttons
            {
                Method = new Action(() =>
                { 
                    Console.SetCursorPosition(x + 2, y + 9);
                    Console.Write("13:00-14:30");
                }),
                command = 3
            };
            var Button_1430_1600 = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 2, y + 13);
                    Console.Write("14:30-16:00");
                }),
                command = 1
            };
            var Button_1600_1730 = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 2, y + 17);
                    Console.Write("16:00-17:30");
                }),
                command = 2
            };
            var Button_1730_1900 = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 2, y + 21);
                    Console.Write("17:30-19:00");
                }),
                command = 3
            };
            var select = new ConsoleMenu(Button_1000_1130, Button_1130_1300, Button_1300_1430, Button_1430_1600, Button_1600_1730, Button_1730_1900)
            {
                x = x,
                y = y
            };


            Window_Main(x - 19, y - 3, 28, 53);
            Console.SetCursorPosition(x, y - 2);
            Console.Write("Выберите время:");
            Window_Button(x, y);

            Window_Button(x, y + 4);

            Window_Button(x, y + 8);

            Window_Button(x, y + 12);
      
            Window_Button(x, y + 16);

            Window_Button(x, y + 20);
            select.Show();
        }

        public static void Table(int x, int y)
        {
            var Button_12 = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 6, y + 1);
                    Console.Write("1-2");
                }),
                command = 1
            };
            var Button_25 = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 6, y + 6);
                    Console.Write("2-5");
                }),
                command = 2
            };
            var Button_6 = new Buttons
            {
                Method = new Action(() =>
                {
                    Console.SetCursorPosition(x + 7, y + 11);
                    Console.Write("5+");
                }),
                command = 3
            };
            var select = new ConsoleMenu(Button_12, Button_25, Button_6)
            {
                x = x,
                y = y
            };

            Window_Main(x - 19, y - 6, 25, 53);

            Console.SetCursorPosition(x - 7, y - 2);
            Console.Write("На сколько человек бронируете?");
            Window_Button(x, y);

            Window_Button(x, y + 5);

            Window_Button(x, y + 10);
            select.Show();
        }
    }
}