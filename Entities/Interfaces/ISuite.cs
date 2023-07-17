// Princípio da responsabilidade única: cada classe tem uma única responsabilidade
// Princípio da substituição de Liskov: as subclasses podem ser substituídas pelas suas superclasses sem alterar o comportamento do programa
// Princípio da segregação de interface: as interfaces são pequenas e específicas, e as classes implementam apenas as interfaces que precisam

// Uma interface para representar uma suíte de hotel

using SistemaDeReservasHotel.Entities.Enums;

namespace SistemaDeReservasHotel.Entities.Interfaces
{
    public interface ISuite
    {
        // O preço da suíte por noite
        decimal Price { get; }

        // O número da suíte
        int Number { get; }

        // O status da suíte: livre, reservada ou ocupada
        SuiteStatus Status { get; set; }

        // Um método para reservar a suíte
        void Reserve();

        // Um método para cancelar a reserva da suíte
        void Cancel();

        // Um método para ocupar a suíte
        void Occupy();

        // Um método para liberar a suíte
        void Release();
    }
}