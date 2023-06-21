using Servis;
var birds = new List<int>() {5, 4, 5, 9, 4, 9, 1};

var birdCount = new HasDayWithoutBirds(birds);

birdCount.LastWeek();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine(birdCount.FalseTrue());


