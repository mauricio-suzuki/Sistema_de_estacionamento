using Sistema_de_estacionamento;
class Program
{
    
    static void Main(string[] args)
    {
        int opcao;
       Estacionamento estacionamento = new Estacionamento();

        Console.WriteLine("==============================");
        Console.WriteLine("BEM-VINDO AO ESTACIONAMENTO X");
        Console.WriteLine("==============================");

        do
        {  
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Listar veículos");
            Console.WriteLine("3 - Quantidade de veículos");
            Console.WriteLine("4 - Remover veículo");
            Console.WriteLine("5 - Sair");
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
               
                 case 1: estacionamento.AdicionarVeiculo();
                      break;
                 case 2: estacionamento.ListarVeículos();
                      break;
                case 3: estacionamento.QtdVeiculo(); 
                      break;
                case 4: estacionamento.RemoverVeículo();
                     break;
            }


        } while (opcao != 5);

    }
        
}
