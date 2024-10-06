public class ScriptureTasks
{
    private List<Scripture> scriptures = new List<Scripture>();

    public void AddScripture(Reference reference, string text)
    {
        scriptures.Add(new Scripture(reference, text));
    }

    public Scripture RandomScripture()
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("The scripture library is empty.");
            return null;
        }

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}