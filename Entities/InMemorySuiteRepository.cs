// Uma classe concreta para representar um repositório de suítes em memória, que implementa a interface ISuiteRepository e usa uma lista interna para armazenar as suítes

using testeSuites.Entities.Interfaces;

namespace testeSuites.Entities
{
    public class InMemorySuiteRepository : ISuiteRepository
    {
        // Uma lista privada para armazenar as suítes
        private readonly List<ISuite> suites = new();

        // Um método para adicionar uma suíte à lista, verificando se ela já existe
        public void Add(ISuite suite)
        {
            if (suite == null)
            {
                throw new ArgumentNullException(nameof(suite));
            }

            if (suites.Contains(suite))
            {
                throw new ArgumentException($"A suíte {suite.Number} já existe no repositório.");
            }

            suites.Add(suite);
            Console.WriteLine($"A suíte {suite.Number} foi adicionada ao repositório.");
        }

        // Um método para remover uma suíte da lista, verificando se ela existe
        public void Remove(ISuite suite)
        {
            if (suite == null)
            {
                throw new ArgumentNullException(nameof(suite));
            }

            if (!suites.Contains(suite))
            {
                throw new ArgumentException($"A suíte {suite.Number} não existe no repositório.");
            }

            suites.Remove(suite);
            Console.WriteLine($"A suíte {suite.Number} foi removida do repositório.");
        }

        // Um método para obter uma suíte da lista pelo seu número, usando o método Find
        public ISuite GetByNumber(int number)
        {
            return suites.Find(s => s.Number == number);
        }

        // Um método para obter todas as suítes da lista, usando o método ToArray
        public IEnumerable<ISuite> GetAll()
        {
            return suites.ToArray();
        }
    }
}