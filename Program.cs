namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fullName = new string [0];
            string[] position = new string[0];
            bool programIsOn = true;

            Console.SetCursorPosition(40,0);
            ShowMenu();

            static void ShowMenu()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Здравствуйте! Какая операция Вас интересует: ");
                Console.WriteLine("1 - Добавить досье");
                Console.WriteLine("2 - Вывести все досье");
                Console.WriteLine("3 - Удалить досье");
                Console.WriteLine("4 - Поиск по фамилии");
                Console.WriteLine("5 - Выход из программы");
            }
 
            while (programIsOn)
            {
                MenuNavigate(fullName, position, programIsOn);
            }

        }
        static void MenuNavigate(string[] fullName, string[] position, bool programIsOn)
        {
            string userMenuNavigate = null;
            userMenuNavigate = Console.ReadLine();

            switch (userMenuNavigate)
            {
                case "1":
                    AddDosier(userMenuNavigate, fullName, position);
                    break;
                case "2":
                    ShowAllDosier(userMenuNavigate, fullName, position);
                    break;
                case "3":
                    Console.WriteLine("Какое досье Вы хотите удалить");
                    break;
                case "4":
                    Console.WriteLine("Введите фамилию для поиска: ");
                    break;
                case "5":
                    Console.Clear();
                    Console.SetCursorPosition(40, 5);
                    Console.WriteLine("Работа программы завершена.");
                    programIsOn = false;
                    break;
                default:
                    Console.WriteLine("Не введено релеватного значения. Попробуйте еще раз.");
                    programIsOn = false;
                    break;
            }
        }
        static void AddDosier (string userMenuNavigate, string[] fullName, string[] position)
        {
            Console.WriteLine("Введите Ваше ФИО или нажмите пункт меню, чтобы переместиться.");
            userMenuNavigate = Console.ReadLine();

            string[] fullNameTemp = new string[fullName.Length + 1];

            for (int i = 0; i < fullName.Length; i++)
            {
                fullNameTemp[i] = fullName[i];
            }

            fullNameTemp[fullNameTemp.Length - 1] = userMenuNavigate;
            fullName = fullNameTemp;
            Console.WriteLine("Введите Вашу должность: ");
            userMenuNavigate = Console.ReadLine();
            string[] positionTemp = new string[position.Length + 1];

            for (int i = 0; i < position.Length; i++)
            {
                positionTemp[i] = position[i];
            }

            positionTemp[positionTemp.Length - 1] = userMenuNavigate;
            position = positionTemp;
            
        }
        static void ShowAllDosier (string userMenuNavigate, string[] fullName, string[] position)
        {
            Console.Clear();
            Console.WriteLine("Всё досье: ");

            foreach (string name in fullName)
            {
                Console.Write(name + " ");
            }

            foreach (string pos in position)
            {
                Console.Write(pos + " ");
            }

        }
    }
}
