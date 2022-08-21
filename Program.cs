namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fullName = new string[0];
            string[] position = new string[0];
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
                        DeleteDosier(ref fullName, ref position);
                        break;
                    case "4": 
                        SearchByDosier(fullName);
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
            ExpansionArray(ref fullName, ref position);

        }
       
        static void ExpansionArray(ref string[] fullName, ref string[] position)
        {
            string userMenuNavigate = Console.ReadLine();
            string[] fullNameTemp = new string[fullName.Length + 1];

            for (int i = 0; i < fullName.Length; i++)
            {
                fullNameTemp[i] = fullName[i];
            }

            fullNameTemp[fullNameTemp.Length - 1] = userMenuNavigate;
            fullName = fullNameTemp;

            Console.WriteLine("Введите должность: ");
            userMenuNavigate = Console.ReadLine();
            string[] positionTemp = new string[position.Length + 1];

            for (int i = 0; i < position.Length; i++)
            {
                positionTemp[i] = position[i];
            }

            positionTemp[positionTemp.Length - 1] = userMenuNavigate;
            position = positionTemp;
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

        static void DeleteDosier(ref string[] fullName, ref string[] position)
        {

            Console.WriteLine("Какое досье Вы хотите удалить");
            int dosierDeleting = Convert.ToInt32(Console.ReadLine());

            if (dosierDeleting > 0 && fullName.Length >= 1)
            {
                DeletingDosier(ref fullName, ref position, dosierDeleting);
            }
            else
            {
                Console.WriteLine("Некорректное значение");
            }

        }

        static void DeletingDosier(ref string[] fullName, ref string[] position, int dosierDeleting)
        {
            int index = dosierDeleting - 1;
            string[] fullNameTemp = new string[fullName.Length - 1];

            for (int i = 0; i < index; i++)
            {
                fullNameTemp[i] = fullName[i];
            }

            for (int i = index + 1; i < fullName.Length; i++)
            {
                fullNameTemp[i - 1] = fullName[i];
            }

            fullName = fullNameTemp;

            string[] positionTemp = new string[position.Length - 1];

            for (int i = 0; i < index; i++)
            {
                positionTemp[i] = position[i];
            }

            for (int i = index + 1; i < position.Length; i++)
            {
                positionTemp[i- 1] = position[i];
            }

            position = positionTemp;
        }

        static void SearchByDosier(string[] fullName)
        {
            Console.WriteLine("Введите фамилию для поиска: ");
            string userMenuNavigate = Console.ReadLine();
            int searchByDosier = Array.IndexOf(fullName, userMenuNavigate);

            if (searchByDosier > -1)
            {
                Console.WriteLine("Элемент " + userMenuNavigate + " найден");
            }
            else
            {
                Console.WriteLine("Нет данных");
            }

        }
    }
}
