Console.WriteLine("Hello, World!");

string path = @"C:\Users\З - 6\Documents\000\list.txt";
FileInfo list = new FileInfo(path);

string a;
do {

    Console.WriteLine("\nМеню: \n");
    Console.WriteLine("1 - Просмотреть основной список");
    Console.WriteLine("2 - Дополнить список");
    Console.WriteLine("3 - Изменить список");
    Console.WriteLine("4 - Удалить позицию из списка");
    Console.WriteLine("5 - Очистить список");
    Console.WriteLine("6 - Выйти");

     a = Console.ReadLine(); 
    
    switch (a) {
        
        case "1":
            using (StreamReader reader = new StreamReader(path)) {
                 Console.WriteLine(reader.ReadToEnd());
            };
            break;

        case "2":
            string b = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(path, true)) {
                await writer.WriteLineAsync();
            }
            break;

        case "3":
            break;

        case "4":
           
            break;

        case "5":
            using (StreamWriter writer = new StreamWriter(path, false)) {
                await writer.WriteLineAsync();
                Console.WriteLine("Очищено");            
                    }
            break;

        case "6":
            break;

        default: {
                break;
            }
    }
}
while (a != "6");









