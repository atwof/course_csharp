
Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies.Add("user", "maria");
cookies.Add("email", "maria@gmail.com");
cookies.Add("phone", "991171232");

Console.WriteLine(cookies["user"]);

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There's no key");
}

cookies.Remove("email");
if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There's no key");
}

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine("ALL COOKIES");
foreach (KeyValuePair<string, string> x in cookies)
{
    Console.WriteLine(x.Key + ":" + x.Value); 
}