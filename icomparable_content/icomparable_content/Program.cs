using icomparable_content.Entities;

string path = @"/Users/alissonf/Desktop/out.csv";

try
{
    using(StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new List<Employee>();
        while(!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }

        list.Sort();
        foreach (Employee x in list)
        {
            Console.WriteLine(x);
        }
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}