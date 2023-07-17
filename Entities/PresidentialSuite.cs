namespace SistemaDeReservasHotel.Entities
{
    public class PresidentialSuite : BasicSuite
    {
        // O construtor da classe, que recebe apenas o número da suíte e chama o construtor da superclasse com o preço fixo
        public PresidentialSuite(int number) : base(500, number)
        {
        }
    }
}