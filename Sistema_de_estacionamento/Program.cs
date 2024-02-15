using Sistema_de_estacionamento;
class Program
{
    
    static void Main(string[] args)
    {
        string opcao;
       Estacionamento estacionamento = new Estacionamento();

        Console.WriteLine("==============================");
        Console.WriteLine("BEM-VINDO AO ESTACIONAMENTO X");
        Console.WriteLine("==============================");

        do
        {
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Listar veículos");
            Console.WriteLine("3 - Quantidade de veículos");
            Console.WriteLine("4 - Remover veículo");
            Console.WriteLine("5 - Editar placa");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("========================================");
            opcao = Console.ReadLine();
            Console.Clear();
            switch (opcao)
            {
               
                 case "1": estacionamento.AdicionarVeiculo();
                      break;
                 case "2": estacionamento.ListarVeículos();
                      break;
                case  "3": estacionamento.QtdVeiculo(); 
                      break;
                case  "4": estacionamento.RemoverVeículo();
                     break;
                case "5": estacionamento.EditarPlaca();
                    break;
                case "6": Console.WriteLine("Programa encerrado...");
                    break;
                default: Console.WriteLine("Opção inválida");
                    break;
            }

            
        } while (opcao != "6");

    }
        
}
