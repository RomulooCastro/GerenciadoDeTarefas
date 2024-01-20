
// Classe para manipulação de tarefas
public class ListarTarefa
{
    private List<Tarefa> tarefas;

    public ListarTarefa()
    {
        tarefas = new List<Tarefa>();
    }

    // Método para adicionar uma nova tarefa
    public void AddTarefa(string descricao)
    {
        Tarefa novaTarefa = new Tarefa(tarefas.Count + 1, descricao);
        tarefas.Add(novaTarefa);
        Console.WriteLine("Tarefa adicionada com sucesso.");
    }

    // Método para listar todas as tarefas 
    public void ListarTarefas()
    {
        Console.WriteLine("Lista de Tarefas:");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"{tarefa.ID}. {tarefa.Descricao}");
        }
    }

    // Método para excluir uma tarefa com base no número fornecido
    public void DeletarTarefa(int numeroTarefa)
    {
        Tarefa tarefaParaExcluir = tarefas.Find(t => t.ID == numeroTarefa);

        if (tarefaParaExcluir != null)
        {
            tarefas.Remove(tarefaParaExcluir);
            Console.WriteLine("Tarefa excluída com sucesso.");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
    }
}

