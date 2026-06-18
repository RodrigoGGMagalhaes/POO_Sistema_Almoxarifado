public class Produto
{
    private int idProduto;
    private string nome;
    private string descricao;
    private double preco;
    private string categoria;
    private List<Fornecedor> fornecedores;

    public Produto(int idProduto, string nome, string descricao, double preco, string categoria)
    {
        this.idProduto = idProduto;
        this.nome = nome;
        this.descricao = descricao;
        this.preco = preco;
        this.categoria = categoria;
        fornecedores = new List<Fornecedor>();
    }

    public void AdicionarFornecedor(Fornecedor fornecedor)
    {
        fornecedores.Add(fornecedor);
    }
}

public class Lote
{
    private int idLote;
    private string codigoLote;
    private int quantidadeAtual;
    private DateTime dataValidade;
    private Produto produto;

    public Lote(int idLote, string codigoLote, int quantidadeAtual, DateTime dataValidade, Produto produto)
    {
        this.idLote = idLote;
        this.codigoLote = codigoLote;
        this.quantidadeAtual = quantidadeAtual;
        this.dataValidade = dataValidade;
        this.produto = produto;
    }

    public void AdicionarQuantidade(int quantidade)
    {
        if (quantidade > 0)
        {
            quantidadeAtual += quantidade;
        }
    }

    public bool RemoverQuantidade(int quantidade)
    {
        if (quantidade > 0 && quantidade <= quantidadeAtual)
        {
            quantidadeAtual -= quantidade;
            return true;
        }
        return false;
    }
}