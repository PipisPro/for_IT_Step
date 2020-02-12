using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using static System.Console;

namespace bankomat
{
    public class Menu
    {
        private Account acc;
        private Client people;
        public void menu()
        {
            string s = "\t\t\t\t\tПривет!!!\n\n\t\t\t\tДобро пожаловать в наш банк \n\n\t\t\t\tВы должны пройти регестрацияю \n\n\n";
            string Name;
            string Fname;
            string Pname;
            int pass;
            int key = new Random().Next(1, 99999);

            for (int i = 0; i < s.Length; i++)
            {
                Write(s[i]);
                Thread.Sleep(20);
            }

            /* 000000000000000000000000000000000000000000000000000 */
            int check_reg = 0;

            WriteLine("\t\t\t\t\tВведите ваше имя \n");
            ForegroundColor = ConsoleColor.Red;
            Name = ReadLine();
            ResetColor();

            WriteLine("\t\t\t\t\tВведите вашу фамилию \n");
            ForegroundColor = ConsoleColor.Red;
            Fname = ReadLine();
            ResetColor();

            WriteLine("\t\t\t\t\tВведите ваше Отчество \n");
            ForegroundColor = ConsoleColor.Red;
            Pname = ReadLine();
            ResetColor();

            WriteLine("\t\t\t\t\tВаш ID \n");
            ForegroundColor = ConsoleColor.Red;
            WriteLine(key);
            ResetColor();

            int check_pass = 0;
            do
            {
                WriteLine("\t\t\t\tВведите вами придуманный пароль \n");
                ForegroundColor = ConsoleColor.Red;
                try
                {
                    pass = int.Parse(ReadLine());
                    check_pass = 1;
                }
                catch
                {
                    WriteLine("Вы ввели текст. Введите числа.");
                }
                ResetColor();
            } while (check_pass == 0);

            WriteLine("Регистрация прошла успешно.");
            ReadKey();

            /* 000000000000000000000000000000000000000000000000000 */


            /* 111111111111111111111111111111111111111111111111111 */

            Clear();
            string f = "\t\tТеперь что-бы зайти в систему вы должны заполнить все поля\n\n";
            for (int i = 0; i < f.Length; i++)
            {
                Write(f[i]);
                Thread.Sleep(20);
            }

            WriteLine("\t\t\t\tВаше имя  ");
            ForegroundColor = ConsoleColor.Red;
            Name = ReadLine();
            ResetColor();

            WriteLine("\t\t\t\tВаша фамилия  ");
            ForegroundColor = ConsoleColor.Red;
            Fname = ReadLine();
            ResetColor();

            WriteLine("\t\t\t\tВаше отчество  ");
            ForegroundColor = ConsoleColor.Red;
            Pname = ReadLine();
            ResetColor();

            int check_pass2 = 0;
            do
            {
                WriteLine("\t\t\t\tВаш пароль");
                ForegroundColor = ConsoleColor.Red;
                try
                {
                    pass = int.Parse(ReadLine());
                    check_pass2 = 1;
                }
                catch
                {
                    WriteLine("Введите целое число");
                }
                ResetColor();
            } while (check_pass2 == 0);

            WriteLine("аторизация прошла успешно");
            ReadKey();

            /* 111111111111111111111111111111111111111111111111111 */


            /* 222222222222222222222222222222222222222222222222222 */

            int checker_32 = 0;
            do
            {
                Clear();                
                WriteLine($"\t Добро пожаловать в наш банк {people.Name}.");
                WriteLine("\t\t 1.Вывести баланс.");
                WriteLine("\t\t 2.Пополнить счёт.");
                WriteLine("\t\t 3.Снять со счёта.");
                WriteLine("\t\t 4.Выйти из системы.");
                int op = int.Parse(ReadLine());
                int check_33 = 0;
                do
                {
                    switch (op)
                    {
                        case 1:
                            {
                                WriteLine("\t\tПросмотр баланса");
                                acc.show_balance();
                                ReadKey();
                                break;
                            }

                        case 2:
                            {
                                WriteLine("\t\tПополнить счет");
                                WriteLine("Введите сумму");
                                int qwerty = int.Parse(ReadLine());
                                acc.credit(qwerty);
                                WriteLine("\n\nУспешно пополнен");
                                ReadKey();
                                Clear();
                                break;
                            }

                        case 3:
                            {
                                WriteLine("\t\tПополнить счет");
                                WriteLine("Введите сумму");
                                int qwertyy = int.Parse(ReadLine());
                                try
                                {
                                    acc.debit(qwertyy);
                                }
                                catch (Exception)
                                {
                                    WriteLine("\t\tНету денег :(");

                                    ReadKey();
                                    break;
                                }
                                WriteLine("\n\nУспешно снято");
                                ReadKey();
                                Clear();
                                break;
                            }

                        case 4: { Clear(); menu(); check_33 = 1; break; }

                        default:
                            {
                                WriteLine("неправильно ввели");
                                ReadKey();
                                break;
                            }
                    }
                } while (check_33 == 0);

                checker_32 = 1;
            } while (checker_32 == 0);

            /* 222222222222222222222222222222222222222222222222222 */


            Clear();
        }

    }
}