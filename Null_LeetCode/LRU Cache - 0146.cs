using System.Collections.Generic;

namespace Null_LeetCode;

public class LRUCache
{
    private Dictionary<int, LinkedListNode<(int key, int value)>> _dictionary = new();
    private LinkedList<(int key, int value)> _values = new();
    private int _capacity;
    
    public LRUCache(int capacity)
    {
        _capacity = capacity;
    }

    public int Get(int key)
    {
        if (!_dictionary.ContainsKey(key))
            return -1;

        var node = _dictionary[key];
        _values.Remove(node);
        _values.AddFirst(node);

        return node.Value.value;
    }
    
    public void Put(int key, int value)
    {
        if (!_dictionary.ContainsKey(key) && _dictionary.Count >= _capacity)
        {
            var node = _values.Last;
            _dictionary.Remove(node.Value.key);
            _values.Remove(node);
        }

        _dictionary.TryGetValue(key, out var existingNode);
        if (existingNode != null)
        {
            _values.Remove(existingNode);
        }

        _values.AddFirst((key, value));
        _dictionary[key] = _values.First;
    }
}