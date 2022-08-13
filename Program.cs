namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fullName = null;
            string[] position;
            bool exit = false;

            Console.SetCursorPosition(40,0);
            Console.WriteLine("Здравствуйте! Введите номер операции: ");
            showMenu();

            static void showMenu()
            {
                Console.WriteLine("1 - Добавить досье");
                Console.WriteLine("2 - Вывести все досье");
                Console.WriteLine("3 - Удалить досье");
                Console.WriteLine("4 - Поиск по фамилии");
                Console.WriteLine("5 - Выход из программы");
            }

            while (exit != true)
            {
                string userInput = null;
                int userMenuNavigate = 0;
                userMenuNavigate = Convert.ToInt32(Console.ReadLine());
               
                switch(userMenuNavigate)
                {
                    case 1:
                        Console.WriteLine("Введите Ваше ФИО и должность с порядковым номером в начале: ");
                        userInput = Console.ReadLine();
                        fullName = userInput.Split();

                        foreach (string name in fullName)
                        {
                            Console.Write(name + " ");
                        }

                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("Какое досье Вы хотите удалить");
                        break;
                    case 4:
                        Console.WriteLine("Введите фамилию для поиска: ");
                        break;
                    case 5:
                        exit = true;
                        Console.Clear();
                        Console.SetCursorPosition(40,5);
                        Console.WriteLine("До свидания!");
                        break;
                }
            }

        }
    }
}
