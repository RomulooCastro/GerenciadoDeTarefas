
// Classe que representa uma tarefa
public class Tarefa
{
    // Propriedades da tarefa (ID e Descrição)
    public int ID { get; set; }
    public string Descricao { get; set; }
    // Construtor que inicializa as propriedades da tarefa
    public Tarefa(int id, string descricao)
    {
        ID = id;
        Descricao = descricao;
    }
}