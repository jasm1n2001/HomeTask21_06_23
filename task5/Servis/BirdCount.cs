public class BirdCount 
{
    List<int> listWeek = new List<int> {2, 5, 0, 7, 4, 1};
     
     public int CountForFirstDays(int n)
     {
        int sum = 0;
        for(int i = 0; i<n; i++)
        {
            sum += listWeek[i];
        }
        return sum;
     }
}