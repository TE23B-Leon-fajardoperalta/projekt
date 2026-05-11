

public class Game
{
    public int Start()
    {
        int num = 0;
        bool foolish = false;
        bool fool = false;

        // kollar efter ett nummer och så länge det inte är det så skriver de ut linje 21 console writeline gör rätt med ett scope och med ett scope med hur stort nummeret får vara 

        while (fool == false) 
        {
            string lol = Console.ReadLine();
            num = 0;

            foolish = int.TryParse(lol, out num);

            if (foolish == true && num < 1 || num > 6)
            {
                fool = false;
            }
            else
            {
                fool = true;
                Console.WriteLine("fool elikamed true");
            }
            

            Console.WriteLine("skriv ett nummer från 1 till 6");
        

        }
        Console.WriteLine("ute ur looper");
        return num;
    }


}