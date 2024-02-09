using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_estacionamento
{
    public class Estacionamento
    {
        public List<string> veiculos = new List<string>();
        public string placa { get; set; }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine("Veículo adicionado com sucesso");
            Console.ReadKey();
            Console.Clear();
        }

        public void ListarVeículos()
        {
            Console.WriteLine("Lista de veículos:");
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);

            }
            Console.ReadKey();
            Console.Clear();
        }

        public void RemoverVeículo()
        {
            Console.WriteLine("Lista de veículos:");
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);

            }
            Console.WriteLine("Digite a placa do veículo");
            placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                veiculos.Remove(placa);
                Console.WriteLine("Veículo removido com sucesso!");
                Console.ReadKey();
                Console.Clear();
            }

            else
            {
                Console.WriteLine("Veículo não encontrado");
                Console.Clear();
            }
        }

        public void QtdVeiculo()
        {
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"Veiculo{i + 1}: {veiculos[i]}");
            }

            Console.ReadKey();
            Console.Clear();


        }
    }
}
