using Services;

namespace Desafio.Testes.Unitarios.Tests;

public class ValidacoesStringTests
{
    // Inicia a classe testada
    ValidacoesString validacoesString = new ValidacoesString();

    [Fact] // Testa o método AStringEVazia
    public void RecebeUmaStringVaziaEDeveRetornarFalse() {
        // Arrange
        string texto = "";

        // Act
        var resultado = validacoesString.AStringEVazia(texto);

        // Assert
        Assert.False(resultado);
    }

    [Fact] // Testa o método AStringEVazia
    public void RecebeUmaStringComEspacoVazioEDeveRetornarFalse() {
        // Arrange
        string texto = " ";

        // Act
        var resultado = validacoesString.AStringEVazia(texto);

        // Assert
        Assert.False(resultado);
    }

    [Fact] // Testa o método AStringEVazia
    public void RecebeUmaStringComConteudoEDeveRetornarTrue() {
        // Arrange
        string texto = "Teste";

        // Act
        var resultado = validacoesString.AStringEVazia(texto);

        // Assert
        Assert.True(resultado);
    }

    [Fact] // Testa o método AStringEUmNumero
    public void RecebeUmaStringComLetrasEDeveRetornarFalse() {
        // Arrange
        string texto = "Hello";

        // Act
        var resultado = validacoesString.AStringEUmNumero(texto);

        // Assert
        Assert.False(resultado);
    }

    [Fact] // Testa o método AStringEUmNumero
    public void RecebeUmaStringMistaEDeveRetornarFalse() {
        // Arrange
        string texto = "ZZYZXRD99";

        // Act
        var resultado = validacoesString.AStringEUmNumero(texto);

        // Assert
        Assert.False(resultado);
    }

    [Fact] // Testa o método AStringEUmNumero
    public void RecebeUmaStringSomenteComNumerosEDeveRetornarTrue() {
        // Arrange
        string texto = "999";

        // Act
        var resultado = validacoesString.AStringEUmNumero(texto);

        // Assert
        Assert.True(resultado);
    }

    [Fact] // Testa o metodo ContarCaracteres
    public void RecebeUmaStringComZeroCaracteresEDeveRetornarZero() {
        // Arrange
        string texto = "";

        // Act
        var resultado = validacoesString.ContarCaracteres(texto);

        // Assert
        Assert.Equal(0, resultado);
    }

    [Fact] // Testa o metodo ContarCaracteres
    public void RecebeUmaStringComDezCaracteresEDeveRetornarDez() {
        // Arrange
        string texto = "0123456789";

        // Act
        var resultado = validacoesString.ContarCaracteres(texto);

        // Assert
        Assert.Equal(10, resultado);
    }

    [Fact] // Testa o método IniciaCom
    public void RecebeUmaStringQueNaoIniciaComALetraOuPalavraBuscadaEDeveRetornarFalse() {
        // Arrange
        string texto = "Rafaela";
        string letraOuPalavraBuscada = "A";

        // Act
        var resultado = validacoesString.IniciaCom(texto, letraOuPalavraBuscada);

        // Assert
        Assert.False(resultado);
    }

    [Fact] // Testa o método IniciaCom
    public void RecebeUmaStringQueIniciaComALetraOuPalavraBuscadaEDeveRetornarTrue() {
         // Arrange
         string texto = "Rafaela";
         string letraOuPalavraBuscada = "r";

         // Act
         var resultado = validacoesString.IniciaCom(texto, letraOuPalavraBuscada);

         // Assert
         Assert.True(resultado);
    }

    [Fact] // Testa o método TerminaCom
    public void RecebeUmaStringQueNaoTerminaComALetraOuPalavraBuscadaEDeveRetornarFalse() {
        // Arrange
        string texto = "Rafaela";
        string letraOuPalavraBuscada = "R";

        // Act
        var resultado = validacoesString.TerminaCom(texto, letraOuPalavraBuscada);

        // Assert
        Assert.False(resultado);
    }

    [Fact] // Testa o método TerminaCom
    public void RecebeUmaStringQueTerminaComALetraOuPalavraBuscadaEDeveRetornarTrue() {
         // Arrange
         string texto = "Rafaela";
         string letraOuPalavraBuscada = "A";

         // Act
         var resultado = validacoesString.TerminaCom(texto, letraOuPalavraBuscada);

         // Assert
         Assert.True(resultado);
    }

    [Fact] // Testa o método ContemLetraOuPalavra
    public void RecebeUmaStringQueNaoContemALetraOuPalavraBuscadaEDeveRetornarFalse() {
        // Arrange
        string texto = "Rafaela";
        string letraOuPalavraBuscada = "Z";

        // Act
        var resultado = validacoesString.ContemLetraOuPalavra(texto, letraOuPalavraBuscada);

        // Assert
        Assert.False(resultado);
    }

    [Fact] // Testa o método ContemLetraOuPalavra
    public void RecebeUmaStringQueContemALetraOuPalavraBuscadaEDeveRetornarFalse() {
        // Arrange
        string texto = "Rafaela";
        string letraOuPalavraBuscada = "F";

        // Act
        var resultado = validacoesString.ContemLetraOuPalavra(texto, letraOuPalavraBuscada);

        // Assert
        Assert.True(resultado);
    }
}