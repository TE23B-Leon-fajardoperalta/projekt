

public class Game
{
    public int Start()
    {

        
        List<int> difficulty = [];
        int num = 0;
        bool success = false;
        bool fool = false;

        // kollar efter ett nummer och så länge det inte är det så skriver de ut linje 21 console writeline gör rätt med ett scope och med ett scope med hur stort nummeret får vara 

        while (fool == false) 
        {
            
            string lol = Console.ReadLine();
            num = 0;

            success = int.TryParse(lol, out num);

            if (success == true && (num >= 1 && num <= 6))
            {
                fool = true;
                difficulty.Add(num);
            }
            else
            {
                fool = false;
                
            }
            

            Console.WriteLine("skriv ett nummer från 1 till 6");
        

        }
        Console.WriteLine("ute ur looper");
        return num;
    }


}