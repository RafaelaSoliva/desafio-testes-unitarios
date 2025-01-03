using System.Security.Cryptography.X509Certificates;

namespace Services;

public class ValidacoesString {
    public bool AStringEVazia(string texto) {
        // Retorna verdadeiro se a string não possuir conteúdo
        return !string.IsNullOrWhiteSpace(texto);
    }

    public bool EUmNumero(string texto) {
        // Retorna verdadeiro se a string for composta apenas por números
        return int.TryParse(texto, out int textoInt);
    }

    public int ContarCaracteres(string texto) {
        // Retorna a quantidade de caracteres da string
        return texto.Length;
    }
    
    public bool IniciaCom(string texto, string letraOuPalavraBuscada) {
        // Retorna verdadeiro se a string iniciar com a letra ou palavra buscada
        return texto.StartsWith(letraOuPalavraBuscada);
    }

    public bool TerminaCom(string texto, string letraOuPalavraBuscada) {
        // Retorna verdadeiro se a string terminar com a letra ou palavra buscada
        return texto.EndsWith(letraOuPalavraBuscada);
    }
    
    public bool ContemLetraOuPalavra(string texto, string letraOuPalavraBuscada) {
        // Retorna verdadeiro se a letra ou palavra buscada for encontrada
        if (texto.Contains(letraOuPalavraBuscada)) {
            return true;
        } else {
            return false;
        }
    }
}