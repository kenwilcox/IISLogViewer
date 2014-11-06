using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace IISLogParser
{
  // My best guess, parse each line to a dictionary, since all the log files could have different columns
  public class LogParser
  {
    private List<Dictionary<string, string>> _logFile;
    private List<string> _fieldNames;

    public DataTable GridList
    {
      get
      {
        DataTable table = new DataTable();
        foreach (string field in _fieldNames)
          table.Columns.Add(field);

        foreach (Dictionary<string, string> line in _logFile)
        {
          DataRow row = table.NewRow();
          foreach (string field in _fieldNames)
          {
            row[field] = line[field];
          }
          table.Rows.Add(row);
        }

        return table;
      }
    }

    public List<string> FieldNames
    {
      get
      {
        return _fieldNames;
      }
    }

    public void ParseLog(string fileName)
    {
      ParseLog(fileName, null);
    }

    public void ParseLog(string fileName, LogParserProgress progress)
    {
      _fieldNames = new List<string>();
      _logFile = new List<Dictionary<string, string>>();
      
      IEnumerable<string> lines = File.ReadLines(fileName);
      var total = lines.Count();
      var position = 0;
      foreach (string line in lines)
      {
        if (progress != null)
        {
          progress(this, position, total);
          position++;
        }

        // Check for the IIS header in the log file
        if (line.StartsWith("#Fields"))
          _fieldNames = ParseFieldNames(line, _fieldNames);

        if (!line.StartsWith("#") && _fieldNames.Count > 0)
        {
          _logFile.Add(ParseLine(line, _fieldNames));
        }
      }
    }

    public List<string> Distinct(string field)
    {
      List<string> ret = new List<string>();
      foreach (Dictionary<string, string> row in _logFile)
      {
        ret.Add(row[field]);
      }
      return ret.Distinct().ToList();
    }

    public DictionaryCount DistinctCount(string field)
    {
      DictionaryCount ret = new DictionaryCount();
      foreach (Dictionary<string, string> row in _logFile)
      {
        ret.Add(row[field]);
      }
      return ret;
    }

    private Dictionary<string, string> ParseLine(string line, List<string> fieldNames)
    {
      Dictionary<string, string> ret = new Dictionary<string, string>();
      string[] fields = line.Split(' ');
      if (fields.Count() == fieldNames.Count)
      {
        for (int i = 0; i < fieldNames.Count; i++)
        {
          ret[fieldNames[i]] = fields[i];
        }
      }
      return ret;
    }

    private List<string> ParseFieldNames(string line, List<string> compare)
    {
      List<string> ret = new List<string>();
      string names = line.Split(':')[1];
      string[] fields = names.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      ret = fields.ToList<string>();
      
      if (!CompareFieldNames(ret, compare)) 
        throw new Exception("FieldNames are different!");
      
      return ret;
    }

    private bool CompareFieldNames(List<string> newList, List<string> oldList)
    {
      bool ret = true;

      try
      {
        for (int i = 0; i < oldList.Count; i++)
        {
          if (newList[i] != oldList[i])
          {
            ret = false;
            break;
          }
        }
      }
      catch
      {
        // We would get here if one list is larger than the other
        ret = false;
      }

      if (oldList.Count != newList.Count) ret = false;
      if (oldList.Count == 0) ret = true;
      return ret;
    }
  }
}
