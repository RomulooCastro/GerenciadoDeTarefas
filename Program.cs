using System;
using System.Collections.Generic;

public class Interacao
{
    static void Main()
    {
        // Instância da classe ListarTarefa para gerenciar as tarefas
        ListarTarefa listarTaref = new ListarTarefa();

        // Loop principal para a interação com o usuário
        while (true)
        {
            // Exibe o menu de opções
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Listar Tarefas");
            Console.WriteLine("3. Excluir Tarefa");
            Console.WriteLine("4. Sair");

            // Solicita ao usuário escolher uma opção
            Console.Write("Escolha uma opção: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Executa a ação à escolha do usuário usando um switch
            switch (choice)
            {
                case 1:
                    Console.Write("Digite a descrição da tarefa: ");
                    string tarefaDescricao = Console.ReadLine();
                    listarTaref.AddTarefa(tarefaDescricao);
                    break;

                case 2:
                    // Lista todas as tarefas
                    listarTaref.ListarTarefas();
                    break;

                case 3:
                    // Lista todas as tarefas e solicita ao usuário o número da tarefa a ser excluída
                    listarTaref.ListarTarefas();
                    Console.Write("Digite o número da tarefa que deseja excluir: ");
                    int tarefaNumero = Convert.ToInt32(Console.ReadLine());
                    // Exclui a tarefa com base no número fornecido
                    listarTaref.DeletarTarefa(tarefaNumero);
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                // Encerra o programa se o usuário escolher sair
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}