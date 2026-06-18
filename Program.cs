// Passei as outras classes para arquivos.cs específicos para deixar Program.cs o menos poluído possível

class Program
{
    static void Main()
    {
        // Apenas testando para ver se os arquivos serão criados
        Relatorio entrada = new RelatorioEntrada();
        Relatorio saida = new RelatorioSaida();

        entrada.Imprimir();
        saida.Imprimir();
    }
}