// Princípio da inversão de dependência: as classes de alto nível não dependem das classes de baixo nível, mas de abstrações
// Princípio da abertura/fechamento: as classes são abertas para extensão, mas fechadas para modificação

// Uma interface para representar um repositório de suítes, que permite adicionar, remover e obter suítes

namespace SistemaDeReservasHotel.Entities.Interfaces
{
    public interface ISuiteRepository
    {
        // Um método para adicionar uma suíte ao repositório
        void Add(ISuite suite);

        // Um método para remover uma suíte do repositório
        void Remove(ISuite suite);

        // Um método para obter uma suíte do repositório pelo seu número
        ISuite GetByNumber(int number);

        // Um método para obter todas as suítes do repositório
        IEnumerable<ISuite> GetAll();
    }
}