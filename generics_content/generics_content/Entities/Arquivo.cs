
namespace Entities
{
    public class Arquivo
    {
        public HashSet<string> Lines { get; set; }
        public List<string> Linhas { get; set; }

        public Arquivo()
        {
            Lines = new HashSet<string>();
            Linhas = new List<string>();
        }

        public void LerArquivo(string path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] lineSplit = line.Split(" ");
                        Lines.Add(lineSplit[0]);
                        Linhas.Add(line);
                    }
                }
            }
            catch(IOException e)
            {
                throw new IOException(e.Message);
            }
        }

        public void MostrarArquivoLidoSemRepeticao()
        {
            foreach (string x in Lines)
            {
                Console.WriteLine(x);
            }
        }

        public void MostrarTodasAsLinhasLidas()
        {
            foreach (string x in Linhas)
            {
                Console.WriteLine(x);
            }
        }

        public int TotalRegistrosDistintos()
        {
            return Lines.Count;
        }
    }
}

