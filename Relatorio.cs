using System;
using System.IO;

public abstract class Relatorio
{
    protected void Cabecalho(StreamWriter writer)
    {
        writer.WriteLine("=== RELATÓRIO ALMOXARIFADO ===");
        writer.WriteLine($"DATA DE EMISSÃO: {DateTime.Now}");
    }

    public abstract void Imprimir();
}

public class RelatorioEntrada : Relatorio
{
    public override void Imprimir()
    {
        using(StreamWriter writer = new StreamWriter("RelatorioEntrada.txt"))
        {
            Cabecalho(writer);

            writer.WriteLine("RELATÓRIO DE ENTRADA");
            writer.WriteLine();
        }
    }
}

public class RelatorioSaida : Relatorio
{
    public override void Imprimir()
    {
        using(StreamWriter writer = new StreamWriter("RelatorioSaida.txt"))
        {
            Cabecalho(writer);

            writer.WriteLine("RELATÓRIO DE SAÍDA");
            writer.WriteLine();
        }
    }
}