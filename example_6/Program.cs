Console.Write("Введите ваше имя:");

string username = Console.ReadLine();

    if(username.ToLower() == "маша")
    {
        Console.WriteLine("Ура!!! Привет МАША");
    }
    else
    {
        Console.Write("Привет, ");
        Console.Write(username);
    }
  