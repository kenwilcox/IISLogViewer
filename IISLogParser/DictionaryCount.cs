using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Data;

namespace IISLogParser
{
  public class DictionaryCount : IDictionary<string, int>
  {
    private Dictionary<string, int> _this;

    public DictionaryCount()
    {
      _this = new Dictionary<string, int>();
    }

    public void Add(string key, int value)
    {
      // no-op
      throw new NotImplementedException("errgh");
      //if (_this.ContainsKey(key))
      //{
      //  int value = _this[key];
      //  _this[key] = value++;
      //}
      //else
      //  _this.Add(key, 1);
    }

    public void Add(string key)
    {
      if (_this.ContainsKey(key))
      {
        int value = _this[key];
        value++;
        _this[key] = value;
      }
      else
        _this.Add(key, 1);
    }

    public DataTable DataTable
    {
      get
      {
        DataTable dt = new DataTable();
        dt.Columns.Add("Value");
        dt.Columns.Add("Count", typeof(int));

        foreach (KeyValuePair<string, int> kvp in _this)
        {
          DataRow row = dt.NewRow();
          row["Value"] = kvp.Key;
          row["Count"] = kvp.Value;
          
          dt.Rows.Add(row);
        }
        return dt;
      }
    }

    public int this[string key]
    {
      get { return _this[key]; }
      set { _this[key] = value; }
    }

    // Required methods for IDictionary
    // just forward to _this
    #region IDictionary<TKey,TValue> Members

    public bool ContainsKey(string key)
    {
      return _this.ContainsKey(key);
    }

    public ICollection<string> Keys
    {
      get { return _this.Keys; }
    }

    public bool Remove(string key)
    {
      return _this.Remove(key);
    }

    public bool TryGetValue(string key, out int value)
    {
      return _this.TryGetValue(key, out value);
    }

    public ICollection<int> Values
    {
      get { return _this.Values; }
    }

    #endregion

    #region ICollection<KeyValuePair<TKey,TValue>> Members

    void ICollection<KeyValuePair<string, int>>.Add(KeyValuePair<string, int> keyValuePair)
    {
      _this.Add(keyValuePair.Key, keyValuePair.Value);
    }

    public void Clear()
    {
      _this.Clear();
    }

    public bool Contains(KeyValuePair<string, int> item)
    {
      return _this.Contains(item);
    }

    //void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
    void ICollection<KeyValuePair<string, int>>.CopyTo(KeyValuePair<string, int>[] array, int index)
    {
      throw new NotImplementedException("This should not be called");
      //foreach (KeyValuePair<string, int> kvp in array)
      //{
      //  array.SetValue(kvp, index);
      //  index += 1;
      //}
    }

    public int Count
    {
      get { return _this.Count; }
    }

    public bool IsReadOnly
    {
      get { return false; }
    }

    bool ICollection<KeyValuePair<string, int>>.Remove(KeyValuePair<string, int> item)
    {
      // This wouldn't be hard to implement!
      throw new NotImplementedException();
    }

    #endregion

    #region IEnumerable<KeyValuePair<TKey,TValue>> Members

    public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
    {
      return _this.GetEnumerator();
    }

    #endregion

    #region IEnumerable Members

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      return _this.GetEnumerator();
    }

    #endregion
  }
}
