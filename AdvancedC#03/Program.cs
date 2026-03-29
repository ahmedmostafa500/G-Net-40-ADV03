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
            #region exercise3
            ////    // Create phone book
            ////    Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            ////{
            ////    {"Ahmed", "0101111111"},
            ////    {"Sara", "0102222222"},
            ////    {"Ali", "0103333333"},
            ////    {"Mona", "0104444444"}
            ////};

            ////    // Add or update using []
            ////    phoneBook["Ahmed"] = "0109999999"; // update
            ////    phoneBook["Omar"] = "0105555555";  // add

            ////    // Try adding duplicate using Add()
            ////    try
            ////    {
            ////        phoneBook.Add("Ahmed", "0000000000");
            ////    }
            ////    catch (Exception ex)
            ////    {
            ////        Console.WriteLine("Error using Add(): " + ex.Message);
            ////    }

            ////    // Try adding duplicate using TryAdd()
            ////    bool added = phoneBook.TryAdd("Ahmed", "0000000000");
            ////    Console.WriteLine("TryAdd success? " + added);

            ////    // Search for a contact that doesn’t exist
            ////    Console.WriteLine("\nContains 'Khaled'? " + phoneBook.ContainsKey("Khaled"));

            ////    // Get contact with fallback
            ////    string result = phoneBook.TryGetValue("Khaled", out string number)
            ////                    ? number
            ////                    : "Not Found";
            ////    Console.WriteLine("Khaled number: " + result);

            ////    // Print all keys in one line
            ////    Console.WriteLine("\nNames: " + string.Join(", ", phoneBook.Keys));

            ////    // Print all values in one line
            ////    Console.WriteLine("Numbers: " + string.Join(", ", phoneBook.Values));
            #endregion
            #region exercise4
            //    // Case-insensitive HashSet
            //    HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};

            //    // Print count
            //    Console.WriteLine("Email Count: " + emails.Count);

            //    // Print stored emails
            //    Console.WriteLine("Stored Emails:");
            //    foreach (var email in emails)
            //    {
            //        Console.WriteLine(email);
            //    }

            //    // Explanation
            //    Console.WriteLine("\nExplanation: Duplicate emails (case-insensitive) are ignored.");

            //    // -----------------------------
            //    // Set Operations
            //    // -----------------------------
            //    HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //    HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //    // Union
            //    var union = new HashSet<int>(setA);
            //    union.UnionWith(setB);
            //    Console.WriteLine("\nUnion: " + string.Join(", ", union));

            //    // Intersection
            //    var intersect = new HashSet<int>(setA);
            //    intersect.IntersectWith(setB);
            //    Console.WriteLine("Intersection: " + string.Join(", ", intersect));

            //    // Except
            //    var except = new HashSet<int>(setA);
            //    except.ExceptWith(setB);
            //    Console.WriteLine("Except (A - B): " + string.Join(", ", except));

            //    // Subset check
            //    HashSet<int> subset = new HashSet<int> { 1, 2 };
            //    Console.WriteLine("\nIs {1,2} subset of A? " + subset.IsSubsetOf(setA));
            #endregion
            #region exercise5
            //// Create queue and add documents
            //Queue<string> printQueue = new Queue<string>();
            //printQueue.Enqueue("Report.pdf");
            //printQueue.Enqueue("Invoice.pdf");
            //printQueue.Enqueue("Letter.docx");
            //printQueue.Enqueue("Resume.pdf");
            //printQueue.Enqueue("Photo.jpg");

            //// Print queue contents
            //Console.WriteLine("Queue Contents:");
            //foreach (var doc in printQueue)
            //{
            //    Console.WriteLine(doc);
            //}

            //// Print count
            //Console.WriteLine("\nCount: " + printQueue.Count);

            //// Peek next document
            //Console.WriteLine("Next to print (Peek): " + printQueue.Peek());

            //// Process queue
            //Console.WriteLine("\nProcessing Queue:");
            //while (printQueue.Count > 0)
            //{
            //    string doc = printQueue.Dequeue();
            //    Console.WriteLine("Printing: " + doc);
            //}

            //// TryDequeue on empty queue
            //bool success = printQueue.TryDequeue(out string result);
            //Console.WriteLine("\nTryDequeue success? " + success);
            //Console.WriteLine("Result: " + (result ?? "null"));

            #endregion
            #region exercise6
            //// Create stack (browser history)
            //Stack<string> history = new Stack<string>();

            //// Push URLs
            //history.Push("google.com");
            //history.Push("github.com");
            //history.Push("stackoverflow.com");
            //history.Push("youtube.com");
            //history.Push("claude.ai");

            //// Current page (top of stack)
            //Console.WriteLine("Current Page: " + history.Peek());

            //// Press "back" 3 times
            //Console.WriteLine("\nGoing Back:");
            //for (int i = 0; i < 3; i++)
            //{
            //    string leftPage = history.Pop();
            //    Console.WriteLine("Leaving: " + leftPage);
            //}

            //// Current page after going back
            //Console.WriteLine("\nCurrent Page After Back: " + history.Peek());

            //// Empty the stack completely
            //while (history.Count > 0)
            //{
            //    history.Pop();
            //}

            //// TryPop on empty stack
            //bool success = history.TryPop(out string result);
            //Console.WriteLine("\nTryPop success? " + success);
            //Console.WriteLine("Result: " + (result ?? "null"));
            #endregion
        }
    }
    
}
