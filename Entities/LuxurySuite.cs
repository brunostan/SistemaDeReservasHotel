namespace testeSuites.Entities
{
    public class LuxurySuite : BasicSuite
    {
        // O construtor da classe, que recebe apenas o número da suíte e chama o construtor da superclasse com o preço fixo
        public LuxurySuite(int number) : base(300, number)
        {
        }
    }
}