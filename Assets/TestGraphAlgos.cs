using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGraphAlgos : MonoBehaviour
{
    public class Graph
    {
        Dictionary<char, Dictionary<char, float>> vertices = new Dictionary<char, Dictionary<char, float>>();

        public void AddVertex(char name, Dictionary<char, float> neighborEdges)
        {
            vertices[name] = neighborEdges;
        }
    }

    Graph g;

    // Start is called before the first frame update
    void Start()
    {
        // A -> B (7)
        // A -> C (8)
        // = A -> (7) B -> (8) C    // not using

        // A -> B-7 -> C-8
        // B -> A-7 -> F-2
        // C -> A-8 -> F-6 -> G-4
        // D -> F-8
        // E -> H-1
        // F -> B-2 -> C-6 -> D-8 -> E-9 -> H-3
        // G -> C-4 -> F-9
        // H -> E-1 -> F-3

        g = new Graph();
        g.AddVertex('A', new Dictionary<char, float>() { { 'B', 7 }, { 'C', 8 } });
        g.AddVertex('B', new Dictionary<char, float>() { { 'B', 7 }, { 'F', 2 } });
        g.AddVertex('C', new Dictionary<char, float>() { { 'A', 8 }, { 'F', 6 }, { 'G', 4 } });
        g.AddVertex('D', new Dictionary<char, float>() { { 'F', 8 } });
        g.AddVertex('E', new Dictionary<char, float>() { { 'H', 1 } });
        g.AddVertex('F', new Dictionary<char, float>() { { 'B', 2 }, { 'C', 6 }, { 'D', 8 }, { 'E', 9 }, { 'H', 3 } });
        g.AddVertex('G', new Dictionary<char, float>() { { 'C', 4 }, { 'F', 9 } });
        g.AddVertex('H', new Dictionary<char, float>() { { 'E', 1 }, { 'F', 3 } });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
