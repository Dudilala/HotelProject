namespace HotelProject
{
    internal class Program
    {
        static string filePath = "rooms.txt";
        static List<Room> hotelRooms = new List<Room>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            LoadDataFromFile();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===СИСТЕМА ЗА УПРАВЛЕНИЕ НА ХОТЕЛ===");
                Console.WriteLine("1. Резервиране на стая");
                Console.WriteLine("2. Освобождаване на стая");
                Console.WriteLine("3. Проверка на наличността и цените на стаите");
                Console.WriteLine("4. Справка за заетите стаи");
                Console.WriteLine("5. Изход");
                Console.Write("Изберете опция (1-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        BookRoom();
                        break;

                    case "2":
                        FreeRoom();
                        break;

                    case "3":
                        CheckAvailabilityAndPrices();
                        break;

                    case "4":
                        ShowOccupiedRooms();
                        break;

                    case "5":
                        Console.WriteLine("Довиждане!");
                        return;

                    default:
                        Console.WriteLine("Невалиден избор. Натиснете бутон за опит...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void LoadDataFromFile()
        {

        }

        static void SaveDataToFile()
        {

        }
        //meli tezi sa za teb
        static void BookRoom()
        {
            Console.WriteLine("---Функция за резервиране на стая---");
            Console.ReadKey();
        }

        static void FreeRoom()
        {
            Console.WriteLine("---Функция за освобождаване на стая---");
            Console.ReadKey();
        }

        static void CheckAvailabilityAndPrices()
        {
            Console.WriteLine("---Функция за проверка на наличността---");
            Console.ReadKey();
        }

        static void ShowOccupiedRooms()
        {
            Console.WriteLine("---Функция за справка за заетите стаи---");
            Console.ReadKey();
        }

    }
 }

