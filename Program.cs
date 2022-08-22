namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fullName = Array.Empty<string>();
            string[] position = Array.Empty<string>();
            bool isProgrammOn = true;
            Console.SetCursorPosition(40, 0);

            static void ShowMenu()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Меню: ");
                Console.WriteLine("1 - Добавить досье");
                Console.WriteLine("2 - Вывести все досье");
                Console.WriteLine("3 - Удалить досье");
                Console.WriteLine("4 - Поиск по фамилии");
                Console.WriteLine("5 - Выход из программы");
            }

            while (isProgrammOn)
            {
                ShowMenu();
                string userMenuNavigate = Console.ReadLine();

                switch (userMenuNavigate)
                {
                    case "1":
                        AddDosier(ref fullName, ref position);
                        break;
                    case "2":
                        ShowAllDosier(fullName, position);
                        break;
                    case "3":
                        ChooseDeletedDosier(ref fullName, ref position);
                        break;
                    case "4":
                        SearchByDosier(fullName, position);
                        break;
                    case "5":
                        Console.Clear();
                        Console.SetCursorPosition(40, 5);
                        Console.WriteLine("Работа программы завершена.");
                        isProgrammOn = false;
                        break;
                    default:
                        Console.WriteLine("Не введено релеватного значения. Попробуйте еще раз.");
                        break;
                }

            }

        }

        static void AddDosier(ref string[] fullName, ref string[] position)
        {
            Console.WriteLine("Введите ФИО: ");
            ExpansionArray(ref fullName);
            Console.WriteLine("Введите должность: ");
            ExpansionArray(ref position);
        }
       
        static void ExpansionArray(ref string[] fullName)
        {
            string userMenuNavigate = Console.ReadLine();
            string[] arrayTemp = new string[fullName.Length + 1];

            for (int i = 0; i < fullName.Length; i++)
            {
                arrayTemp[i] = fullName[i];
            }

            arrayTemp[arrayTemp.Length - 1] = userMenuNavigate;
            fullName = arrayTemp;
        }

        static void ShowAllDosier(string[] fullName, string[] position)
        {
            Console.Clear();
            Console.WriteLine("Всё досье: ");

            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine("ФИО: " + (i + 1) + "-" + fullName[i] + ", должность - " + position[i]);
            }

        }

        static void ChooseDeletedDosier(ref string[] fullName, ref string[] position)
        {
            Console.WriteLine("Какое досье Вы хотите удалить");
            int dosierDeleting = Convert.ToInt32(Console.ReadLine());

            if (dosierDeleting > 0 && fullName.Length >= 1)
            {
                DeleteDosier(ref fullName, dosierDeleting);
                DeleteDosier(ref position, dosierDeleting);
            }
            else
            {
                Console.WriteLine("Некорректное значение");
            }

        }

        static void DeleteDosier(ref string[] fullName, int dosierDeleting)
        {
            int index = dosierDeleting - 1;
            string[] arrayTemp = new string[fullName.Length - 1];

            for (int i = 0; i < index; i++)
            {
                arrayTemp[i] = fullName[i];
            }

            for (int i = index + 1; i < fullName.Length; i++)
            {
                arrayTemp[i - 1] = fullName[i];
            }

            fullName = arrayTemp;     
        }

        static void SearchByDosier(string[] fullName, string[] position)
        {
            Console.WriteLine("Введите фамилию для поиска: ");
            string userMenuNavigate = Console.ReadLine();
            int indexArray = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i].StartsWith(userMenuNavigate, StringComparison.InvariantCultureIgnoreCase))
                {
                    indexArray = i;
                    break;
                }
            }

            if (indexArray == -1)
            {
                Console.WriteLine("Нет результатов");
            }
            else if (indexArray > - 1)
            {
                Console.WriteLine("Досье " + userMenuNavigate +  " найдено под номером : " + (indexArray+1) + " " + fullName[indexArray]+ ", должность: "+ position[indexArray]);
            }

        }
    }
}
