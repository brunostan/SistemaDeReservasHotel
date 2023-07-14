using testeSuites.Entities;

namespace testeSuites
{
    // Um exemplo de uso do sistema de hotel, criando uma instância do sistema com um repositório em memória e realizando algumas operações
    class Program
    {
        static void Main()
        {
            // Criando uma instância do sistema de hotel com um repositório em memória
            HotelSystem system = new(new InMemorySuiteRepository());

            // Criando e adicionando algumas suítes ao repositório
            system.CreateSuite("simples", 101);
            system.CreateSuite("simples", 102);
            system.CreateSuite("luxo", 201);
            system.CreateSuite("luxo", 202);
            system.CreateSuite("presidencial", 301);
            system.CreateSuite("simples", 103);
            system.CreateSuite("simples", 104);
            system.CreateSuite("luxo", 203);
            system.CreateSuite("luxo", 204);
            system.CreateSuite("presidencial", 302);

            // Mostrando os status das suítes
            system.ShowStatus();

            // Reservando algumas suítes
            system.ReserveSuite(101);
            system.ReserveSuite(201);
            system.ReserveSuite(301);

            // Mostrando os status das suítes
            system.ShowStatus();

            // Cancelando a reserva de uma suíte
            system.CancelReservation(201);

            // Ocupando algumas suítes
            system.OccupySuite(101);
            system.OccupySuite(202);

            // Mostrando os status das suítes
            system.ShowStatus();

            // Liberando uma suíte
            system.ReleaseSuite(101);

            // Removendo uma suíte do repositório
            system.DeleteSuite(301);

            // Mostrando os status das suítes
            system.ShowStatus();
        }
    }
}