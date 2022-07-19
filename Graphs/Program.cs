// Graphs

// A graph models a set of connections made up of nodes and edges.
// We can use a Dictionary to map a node to all of its neighbors.

Dictionary<string, string[]> peopleGraph = new Dictionary<string, string[]>();

// This represents a directed graph. To map nodes together, you'd have
// to create an additional entry to map Anuj to Bob for example.

peopleGraph["You"] = new string[] { "Alice", "Bob", "Claire" };
peopleGraph["Bob"] = new string[] { "Anuj", "Peggy" };
peopleGraph["Alice"] = new string[] { "Peggy" };
peopleGraph["Tom"] = new string[] { "Thom", "Johnny" };
peopleGraph["Anuj"] = new string[] { };
peopleGraph["Peggy"] = new string[] { };
peopleGraph["Thom"] = new string[] { };
peopleGraph["Johnny"] = new string[] { };


foreach (var item in peopleGraph["Tom"])
{
    Console.WriteLine(item);
}

