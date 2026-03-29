namespace AdvancedC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exercise1
            //    List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //    // Print collection:
            //    Console.WriteLine("Grades: " + string.Join(", ", grades));

            //    // Count, first, last:
            //    Console.WriteLine("Count: " + grades.Count);
            //    Console.WriteLine("First Grade: " + grades.First());
            //    Console.WriteLine("Last Grade: " + grades.Last());

            //    // Sort ascending:
            //    grades.Sort();
            //    Console.WriteLine("\nSorted Grades: " + string.Join(", ", grades));

            //    // First grade above 90:
            //    int firstAbove90 = grades.FirstOrDefault(g => g > 90);
            //    Console.WriteLine("First Grade > 90: " + firstAbove90);

            //    // Grades below 75:
            //    var failingGrades = grades.Where(g => g < 75).ToList();
            //    Console.WriteLine("Failing Grades (<75): " + string.Join(", ", failingGrades));

            //    // Remove failing grades:
            //    grades.RemoveAll(g => g < 75);
            //    Console.WriteLine("After Removing Failing Grades: " + string.Join(", ", grades));

            //    // Check if any grade equals 100:
            //    bool has100 = grades.Any(g => g == 100);
            //    Console.WriteLine("Contains 100? " + has100);

            //    // Convert to List<string>:
            //    List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            //    Console.WriteLine("String List:");
            //    gradeStrings.ForEach(s => Console.WriteLine(s));
            //}


            #endregion
            #region exercise2

        //    SortedList<int, string> leaderboard = new SortedList<int, string>()
        //{
        //    {500, "Ahmed"},
        //    {200, "Sara"},
        //    {800, "Ali"},
        //    {350, "Mona"}
        //};

        //    // Print all entries
        //    Console.WriteLine("Leaderboard:");
        //    foreach (var entry in leaderboard)
        //    {
        //        Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
        //    }

        //    // Access first key and value (by index)
        //    Console.WriteLine("\nFirst Score: " + leaderboard.Keys[0]);
        //    Console.WriteLine("First Player: " + leaderboard.Values[0]);

        //    // Check if score 500 exists
        //    Console.WriteLine("\nContains score 500? " + leaderboard.ContainsKey(500));

        //    // Safely get player with score 999
        //    if (leaderboard.TryGetValue(999, out string player))
        //        Console.WriteLine("Player with score 999: " + player);
        //    else
        //        Console.WriteLine("Score 999 not found");

        //    // Remove player with score 200
        //    leaderboard.Remove(200);

        //    // Print updated leaderboard
        //    Console.WriteLine("\nUpdated Leaderboard:");
        //    foreach (var entry in leaderboard)
        //    {
        //        Console.WriteLine($"Score: {entry.Key}, Player: {entry.Value}");
        //    }
            #endregion

        }
    }
    
}
