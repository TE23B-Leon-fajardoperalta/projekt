public class Player
{
    private int _dialogue = 0;

    public int Dialogue
    {
        get
        {
            return _dialogue;
        }
        set
        {
            _dialogue = value;
            if (_dialogue < 6) _dialogue = 6;
        }
    }

    public List<int> trinkFight { get; private set; } = [1, 2];
    public List<int> diaShop { get; private set; } = [1, 2];
    public List<int> miniBHeal { get; private set; } = [1, 2];





    private Stack<int> myStack = new Stack<int>();


    public Player()
    {
        int lom = Random.Shared.Next(trinkFight.Count);
        myStack.Push(trinkFight[lom]);
        int lomp = Random.Shared.Next(diaShop.Count);
        myStack.Push(diaShop[lom]);
        int lompy = Random.Shared.Next(miniBHeal.Count);
        myStack.Push(miniBHeal[lom]);
    }
    

}
