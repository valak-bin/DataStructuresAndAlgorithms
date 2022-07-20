// Breadth-first Search

//

//


// Variables

// Create an unweighted directed graph using a Dictionary
Dictionary<string, string[]> peopleGraph = new Dictionary<string, string[]>();

peopleGraph["You"] = new string[] { "Alice", "Bob", "Claire" };
peopleGraph["Bob"] = new string[] { "Anuj", "Peggy" };
peopleGraph["Alice"] = new string[] { "Peggy" };
peopleGraph["Claire"] = new string[] { "Thom", "Johnny" };
peopleGraph["Anuj"] = Array.Empty<string>();
peopleGraph["Peggy"] = Array.Empty<string>();
peopleGraph["Thom"] = Array.Empty<string>();
peopleGraph["Johnny"] = Array.Empty<string>();

// Method Calls
vendorSearch("You");

// Methods
bool vendorSearch(string name)
{
    Queue<string> searchQueue = new Queue<string>();
    List<string> searched = new List<string>();

    foreach (var item in peopleGraph[name])
    {
        searchQueue.Enqueue(item);
    }

    while (searchQueue.Count > 0)
    {
        string person = searchQueue.Dequeue();
        if (!searchQueue.Contains(person))
        {
            if (personIsAVendor(person))
            {
                Console.WriteLine($"{person} is a vendor.");
                return true;
            }
            else
            {
                foreach (var item in peopleGraph[person])
                {
                    searchQueue.Enqueue(item);
                }
                
                searched.Add(person);
            }
        }
    }
    return false;
}

bool personIsAVendor(string name)
{
    return name == "Johnny";
}
