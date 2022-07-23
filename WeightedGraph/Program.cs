// You need three hash tables: network graph, weights, parents
// You also need an array to keep track of all the nodes you've already processed

// Graph
// The dictionary for this is a string key and another dictionary for the value
Dictionary<string, Dictionary<string, int>> graph = new Dictionary<string, Dictionary<string, int>>();

graph["Start"] = new Dictionary<string, int>();
graph["Start"]["A"] = 6;
graph["Start"]["B"] = 2;

graph["A"] = new Dictionary<string, int>();
graph["A"]["Fin"] = 1;

graph["B"] = new Dictionary<string, int>();
graph["B"]["A"] = 3;
graph["B"]["Fin"] = 5;

graph["Fin"] = new Dictionary<string, int>();

// Print all of the keys in a dictionary
Dictionary<string, Dictionary<string, int>>.KeyCollection keys = graph.Keys;
foreach (var key in keys)
{
    Console.WriteLine($"Key: {key}");
}

// Print the edge from Start to A
Console.WriteLine(graph["Start"]["A"]);

// Weights graph

Dictionary<string, double> weights = new Dictionary<string, double>();
weights["A"] = 6;
weights["B"] = 2;
weights["Fin"] = double.PositiveInfinity;

// Parents graph
Dictionary<string, string?> parents = new Dictionary<string, string?>();
parents["A"] = "Start";
parents["B"] = "Start";
parents["Fin"] = null;

// Processed array
string[] processed = Array.Empty<string>();
