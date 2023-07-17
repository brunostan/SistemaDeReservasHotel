using SistemaDeReservasHotel.Entities;

namespace SistemaDeReservasHotel
{
    class Program
    {
        static void Main()
        {
            HotelSystem system = new(new InMemorySuiteRepository());

            system.SetupDefaultSuites();
            system.PromptMenu();
        }
    }
}
