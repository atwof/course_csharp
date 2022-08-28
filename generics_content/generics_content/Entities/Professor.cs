
namespace Entities
{
    public class Professor
    {
        public string Name { get; set; }
        public HashSet<int> Alunos { get; set; }

        public Professor(string name)
        {
            Name = name;
            Alunos = new HashSet<int>();
        }

        public void AdicionarAluno(int x)
        {
            Alunos.Add(x);
        }

        public int RetornarTotalDeAlunos()
        {
            return Alunos.Count;
        }
    }
}

