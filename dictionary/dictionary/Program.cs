// Exercício proposto

string path = @"/Users/alissonf/Desktop/in.txt";
Dictionary<string, int> votes = new Dictionary<string, int>();

/*
try
{
    using(StreamReader reader = File.OpenText(path))
    {
        while (!reader.EndOfStream)
        {
            string[] linha = reader.ReadLine().Split(",");
            string nome = linha[0];
            int votos = int.Parse(linha[1]);

            // Veriicar se a chave já existe
            if (votes.ContainsKey(nome))
            {
                int v = votes.GetValueOrDefault(nome);
                votos += v;
                votes.Remove(nome);
                votes.Add(nome, votos);

            }
            else
            {
                votes.Add(nome, votos);
            }
        }
    }

    // Mostrar a quantidade de votos de cada candidato
    foreach (KeyValuePair<string, int> item in votes)
    {
        Console.WriteLine("Candidato: " + item.Key.ToUpper() + " - Votos: " + item.Value);
    }
}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}
*/

try
{
    using (StreamReader reader = File.OpenText(path))
    {
        while (!reader.EndOfStream)
        {
            string[] linha = reader.ReadLine().Split(",");
            string nome = linha[0];
            int votos = int.Parse(linha[1]);

            // Veriicar se a chave já existe
            if (votes.ContainsKey(nome))
            {
                int v = votes.GetValueOrDefault(nome);
                votos += v;
                votes.Remove(nome);
                votes.Add(nome, votos);

            }
            else
            {
                votes.Add(nome, votos);
            }
        }
    }

    // Mostrar a quantidade de votos de cada candidato
    foreach (KeyValuePair<string, int> item in votes)
    {
        Console.WriteLine("Candidato: " + item.Key.ToUpper() + " - Votos: " + item.Value);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}