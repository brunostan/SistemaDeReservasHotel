namespace testeSuites.Entities
{
    public class SimpleSuite : BasicSuite
    {
        // O construtor da classe, que recebe apenas o número da suíte e chama o construtor da superclasse com o preço fixo
        public SimpleSuite(int number) : base(100, number)
        {
        }
    }
}