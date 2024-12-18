string folderPath = @"C:\list";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    List<string> mySmyShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, mySmyShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} doesnt exist.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}






static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/ EXIT (exit);");
        string userChoise = Console.ReadLine();

        if (userChoise == "add")
        {
            Console.WriteLine("Enter and item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLenght = someList.Count;
    Console.WriteLine($"You have added {listLenght} items to your shopping list.");
    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }