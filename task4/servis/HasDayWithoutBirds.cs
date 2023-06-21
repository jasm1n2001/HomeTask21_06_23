
namespace Servis;
public class HasDayWithoutBirds
{
    List<int> _birds = new List<int>();

    public HasDayWithoutBirds(List<int> birds)
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
    int cnt = 0;
    public bool FalseTrue()
    {
        foreach (var bird in _birds)
        {
           if(bird == 0) cnt++;

        }
        if(cnt>=1) return true;
        else return false;
    }
}