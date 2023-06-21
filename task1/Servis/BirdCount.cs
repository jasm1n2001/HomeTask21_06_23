
public class BirdCount
{
    List<int> _birds = new List<int>();

    public BirdCount(List<int> birds)
    {
       _birds = birds;   
    }

    public void LastWeek()
    {
        System.Console.Write("[");
        foreach (var bird in _birds)
        {
            System.Console.Write($"{bird}, ");
        }
        System.Console.Write("]"); 
    }
}