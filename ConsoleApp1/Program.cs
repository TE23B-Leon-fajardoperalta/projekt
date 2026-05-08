// start sidan/ord man ser när man startar projektet
Console.WriteLine("Press enter to begin");

Console.WriteLine("choose difficulty 1-6");
Console.WriteLine("1-6");

Game spel = new();
Player spelare = new();


spel.Start();

Console.ReadLine();