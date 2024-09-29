using System;

class Entry
{
  public string Prompt;
  public string Response;
  public DateTime Date;

  public Entry(string prompt, string response)
  {
    Prompt = prompt;
    Response = response;
    Date = DateTime.Now;
  }

  public override string ToString()
  {
    return $"Date: {Date} Prompt: {Prompt} Response: {Response}";
  }
}