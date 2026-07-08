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
            if (File.Exists(filePath) == false)
            {
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (line != "")
                {
                    string[] parts = line.Split(';');
                    string roomNumber = parts[0];
                    string type = parts[1];
                    int capacity = int.Parse(parts[2]);
                    double pricePerNight = double.Parse(parts[3]);

                    bool occupied = false;
                    if (parts[4] == "true")
                    {
                        occupied = true;
                    }
                    else
                    {
                        occupied = false;
                    }

                    string guestName = parts[5];

                    Room r = new Room(roomNumber, type, capacity, pricePerNight, occupied, guestName);
                    hotelRooms.Add(r);
                }
            }
        }
        static void SaveDataToFile()
        {
             
                    string[] linesToSave = new string[hotelRooms.Count];

                    for (int i = 0; i < hotelRooms.Count; i++)
                    {
                        linesToSave[i] = hotelRooms[i].ToFileRow();
                    }

                   
                    File.WriteAllLines(filePath, linesToSave);
                
        }

        //meli tezi sa za teb
        static void BookRoom()
        {
            Console.WriteLine("--- РЕЗЕРВИРАНЕ НА СТАЯ ---");
            Console.Write("Въведете номер на стая за резервация: ");
            string number = Console.ReadLine();

            for(int i = 0; i < hotelRooms.Count; i++)
            {
                if (hotelRooms[i].roomNumber == number)
                {
                    if (hotelRooms[i].occupied == true)
                    {
                        Console.WriteLine("Съжaляваме, тази стая вече е заета от друг гост!");
                    }
                    else
                    {
                        Console.WriteLine("Въведете име на госта: ");
                        string name = Console.ReadLine();

                        hotelRooms[i].occupied = true;
                        hotelRooms[i].guestName = name;

                        SaveDataToFile();
                        Console.WriteLine("Стаята беше резервирана успешно! ");
                    }
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Грешка: Стая с такъв номер не съществува!");
            Console.ReadKey();
        }

        static void FreeRoom()
        {
            Console.WriteLine("---Освобождаване на стая---");
            Console.ReadKey();
        }

        static void CheckAvailabilityAndPrices()
        {
            Console.WriteLine("---Проверка на наличността---");
            Console.ReadKey();
        }

        static void ShowOccupiedRooms()
        {
            Console.WriteLine("---Справка за заетите стаи---");
            Console.ReadKey();
        }


    }
 }

