namespace DesafioFundamentos.Models
{
    /// <summary>
    /// Classe que representa um estacionamento
    /// </summary>
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        /// <summary>
        /// Construtor da classe Estacionamento
        /// </summary>
        /// <param name="precoInicial">Preço inicial do estacionamento, quando o veículo entra no estacionamento.</param>
        /// <param name="precoPorHora">Preço por hora do estacionamento</param>
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        /// Método que adiciona um veículo ao estacionamento
        /// leia a placa do veículo e verifica se já existe um veículo estacionado com a mesma placa
        /// Se já existir, exibe uma mensagem informando que o veículo já está estacionado
        /// </summary>
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Esse veículo já está estacionado.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine($"O veículo {placa} foi estacionado com sucesso!");
            }
        }

        /// <summary>
        /// Método que remove um veículo do estacionamento
        /// lê a placa do veículo e verifica se um determinado veículo está estacionado, 
        /// e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. 
        /// Após isso, realiza o seguinte cálculo: precoInicial * precoPorHora, exibindo para o usuário.
        /// Caso o veículo não esteja estacionado, exibe uma mensagem informando que o veículo não está estacionado.
        /// </summary>
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n" +
                                  $"O veículo permaneceu estacionado por {horas} horas.\n" +
                                  $"O preço inicial foi de R$ {precoInicial} e o preço por hora foi de R$ {precoPorHora}.\n" +
                                  $"Obrigado por utilizar nosso estacionamento!\n" +
                                  $"Volte sempre! :)");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        /// <summary>
        /// Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".
        /// </summary>
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
