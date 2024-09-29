using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
  public List<Entry> entries = new List<Entry>();

  public void AddEntry(string prompt, string response)
  {
    Entry entry = new Entry(prompt, response);
    entries.Add(entry);
  }

  public void DisplayAll()
  {
    foreach (Entry entry in entries)
    {
      Console.WriteLine(entry);
    }
  }

  public int EntriesCount()
  {
      return entries.Count;
  }

  public void SaveToFile(string file)
  {
    using (StreamWriter writer = new StreamWriter(file))
    {
      foreach (Entry entry in entries)
      {
        string date = csvValue(entry.Date.ToString("yyyy-MM-dd HH:mm:ss"));
        string prompt = csvValue(entry.Prompt);
        string response = csvValue(entry.Response);

        writer.WriteLine($"{date},{prompt},{response}");
      }
    }
  }

      public string csvValue(string value)
    {
        if (value.Contains("\""))
        {
            value = value.Replace("\"", "\"\"");
        }
        if (value.Contains(",") || value.Contains("\n") || value.Contains("\""))
        {
            value = $"\"{value}\"";
        }
        return value;
    }

  public void LoadFromFile(string file)
  {
    entries.Clear();

    try
    {
      using (StreamReader reader = new StreamReader(file))
      {
        string line;
        string currentPrompt = null;
        string currentResponse = null;
        DateTime currentDate = DateTime.MinValue;

        while ((line = reader.ReadLine()) != null)
        {
          if (line.StartsWith("Date: "))
          {
            currentDate = DateTime.Parse(line.Substring("Date: ".Length));
          }
          else if (line.StartsWith("Prompt: "))
          {
            currentPrompt = line.Substring("Prompt: ".Length);
          }
          else if (line.StartsWith("Response: "))
          {
            currentResponse = line.Substring("Response: ".Length);
            entries.Add(new Entry(currentPrompt, currentResponse)
            {
              Date = currentDate,
              Prompt = currentPrompt,
              Response = currentResponse
            });
          }
        }
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
    }
  }
}