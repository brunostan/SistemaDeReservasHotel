// Uma classe abstrata para representar uma suíte básica, que implementa a interface ISuite

using testeSuites.Entities.Enums;
using testeSuites.Entities.Interfaces;

namespace testeSuites.Entities
{
    public abstract class BasicSuite : ISuite
    {
        // O preço da suíte por noite, definido no construtor
        public decimal Price { get; }

        // O número da suíte, definido no construtor
        public int Number { get; }

        // O status da suíte, inicialmente livre
        public SuiteStatus Status { get; set; } = SuiteStatus.Free;

        // O construtor da classe, que recebe o preço e o número da suíte
        public BasicSuite(decimal price, int number)
        {
            Price = price;
            Number = number;
        }

        // Um método para reservar a suíte, que verifica se ela está livre e altera o seu status para reservada
        public virtual void Reserve()
        {
            if (Status == SuiteStatus.Free)
            {
                Status = SuiteStatus.Reserved;
                Console.WriteLine($"A suíte {Number} foi reservada.");
            }
            else
            {
                Console.WriteLine($"A suíte {Number} não pode ser reservada.");
            }
        }

        // Um método para cancelar a reserva da suíte, que verifica se ela está reservada e altera o seu status para livre
        public virtual void Cancel()
        {
            if (Status == SuiteStatus.Reserved)
            {
                Status = SuiteStatus.Free;
                Console.WriteLine($"A reserva da suíte {Number} foi cancelada.");
            }
            else
            {
                Console.WriteLine($"A suíte {Number} não tem reserva para cancelar.");
            }
        }

        // Um método para ocupar a suíte, que verifica se ela está livre ou reservada e altera o seu status para ocupada
        public virtual void Occupy()
        {
            if (Status == SuiteStatus.Free || Status == SuiteStatus.Reserved)
            {
                Status = SuiteStatus.Occupied;
                Console.WriteLine($"A suíte {Number} foi ocupada.");
            }
            else
            {
                Console.WriteLine($"A suíte {Number} não pode ser ocupada.");
            }
        }

        // Um método para liberar a suíte, que verifica se ela está ocupada e altera o seu status para livre
        public virtual void Release()
        {
            if (Status == SuiteStatus.Occupied)
            {
                Status = SuiteStatus.Free;
                Console.WriteLine($"A suíte {Number} foi liberada.");
            }
            else
            {
                Console.WriteLine($"A suíte {Number} não está ocupada.");
            }
        }
    }
}