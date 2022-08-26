
string path = @"/Users/alissonf/Desktop/in.txt";

try
{
    using(StreamReader sr = File.OpenText(path))
    {
        List<string> list = new List<string>();
        while(!sr.EndOfStream)
        {
            list.Add(sr.ReadLine());
        }

        list.Sort();
        foreach (string x in list)
        {
            Console.WriteLine(x);
        }
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}