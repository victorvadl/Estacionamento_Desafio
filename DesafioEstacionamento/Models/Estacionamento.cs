namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        public decimal lucro;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string? input = Console.ReadLine();

            
            if (input != "" && input != null)
            {
                if (veiculos.Any(x => x.ToUpper() == input.ToUpper()))
                {
                    Console.WriteLine("Veículo já se encontra escationado. Verifique a placa.");
                }
                else
                {
                    veiculos.Add(input);
                } 
            }
            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            string? placa = Console.ReadLine();

            
            if (placa != "" && placa != null)
            {
                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    
                    int.TryParse(Console.ReadLine(), out int horas);
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    lucro += valorTotal;
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }

            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente");  
            }
            
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                
                foreach(string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
