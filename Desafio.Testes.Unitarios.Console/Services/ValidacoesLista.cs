namespace Services;

public class ValidacoesLista {
    public bool AListaEVazia(List<int> lista) {
        // Retorna verdadeiro se a lista não possuir conteúdo
        return lista.Count == 0;
    }

    public bool AListaContemItem(List<int> lista, int itemBuscado) {
        // Retorna verdadeiro se a lista possuir o item buscado
        return lista.Contains(itemBuscado);
    }

    public int ContarItens(List<int> lista) {
        // Retorna a quantidade de itens da lista
        return lista.Count;
    }

    public int ContarItensPares(List<int> lista) {
        // Retorna a quantidade de números pares da lista
        int numerosPares = lista.Count(i => i % 2 == 0);
        return numerosPares;
    }

    public int ContarItensImpares(List<int> lista) {
        // Retorna a quantidade de números ímpares da lista
        int numerosImpares = lista.Count(i => i % 2 == 1);
        return numerosImpares;
    }

    public int RetornarMaiorValor(List<int> lista) {
        // Retorna o maior valor da lista
        return lista.Max();
    }

    public int RetornarMenorValor(List<int> lista) {
        // Retorna o menor valor da lista
        return lista.Min();
    }

    public double RetornarMediaValores(List<int> lista) {
        // Retorna a média dos valores da lista
        return lista.Average();
    }

    public List<int> RemoverValoresNegativos(List<int> lista) {
        // Retorna uma lista sem os valores negativos
        List<int> valoresPositivos = lista.Where(i => i >= 0).ToList();
        return valoresPositivos;
    }

    public List<int> MultiplicarValorDosItens(List<int> lista, int multiplicador) {
        // Retorna uma lista com os valores multiplicados
        List<int> valoresMultiplicados = lista.Select(i => i * multiplicador).ToList();
        return valoresMultiplicados;
    }
}