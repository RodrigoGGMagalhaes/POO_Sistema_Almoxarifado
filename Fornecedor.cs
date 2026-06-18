public class Fornecedor
{
    private int idFornecedor;
    private string nome;
    private string cnpj;
    private string telefone;
    private string email;
    private List<Produto> produtos;

    public Fornecedor(int idFornecedor, string nome, string cnpj, string telefone, string email)
    {
        this.idFornecedor = idFornecedor;
        this.nome = nome;
        this.cnpj = cnpj;
        this.telefone = telefone;
        this.email = email;
        produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }
}