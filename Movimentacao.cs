public class Movimentacao
{
    private int idMovimentacao;
    private DateTime data;
    private string tipo;
    private string observacao;
    private List<ItemMovimentacao> itens;

    public Movimentacao(int idMovimentacao, DateTime data, string tipo, string observacao)
    {
        this.idMovimentacao = idMovimentacao;
        this.data = data;
        this.tipo = tipo;
        this.observacao = observacao;
        itens = new List<ItemMovimentacao>();
    }

    public void AdicionarItem(ItemMovimentacao item)
    {
        itens.Add(item);
    }

    public int CalcularQuantidadeTotal()
    {
        int total = 0;
        foreach (ItemMovimentacao item in itens)
        {
            total += item.ObterQuantidade();
        }
        return total;
    }

    public bool EhEntrada()
    {
        return tipo == "Entrada";
    }

    public bool EhSaida()
    {
        return tipo == "Saida";
    }

    public int ObterIdMovimentacao()
    {
        return idMovimentacao;
    }

    public DateTime ObterData()
    {
        return data;
    }

    public string ObterTipo()
    {
        return tipo;
    }

    public string ObterObservacao()
    {
        return observacao;
    }

    public List<ItemMovimentacao> ObterItens()
    {
        return itens;
    }
}

public class ItemMovimentacao
{
    private Lote lote;
    private int quantidade;

    public ItemMovimentacao(Lote lote, int quantidade)
    {
        this.lote = lote;
        this.quantidade = quantidade;
    }

    public Lote ObterLote()
    {
        return lote;
    }

    public int ObterQuantidade()
    {
        return quantidade;
    }
}