public class BCount 
{
    List<int>  listWeek = new List<int>{2, 5, 0, 7, 4, 1};

    public int  BusyDays()
    {
        int cnt = 0;
        foreach (var bird in listWeek)
        {
            if(bird >= 5)cnt++;
        }
        return cnt;
    }
}