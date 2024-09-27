using System;
using TestesUnitariosTDDCSharp;
using Xunit;

namespace TestesUnitariosTDDCSharpTests
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "27/09/2024";
            Calculadora calculadora = new Calculadora(data);
            return calculadora;
        }

        [Fact]
        public void TesteSomarUmConjunto()
        {
            Calculadora calculadora = construirClasse();

            int resultado = calculadora.somar(1, 2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        public void TesteSomarVariosConjuntos(int a, int b, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoDaCalculadora = calculadora.somar(a, b);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(6, 5, 1)]
        public void TesteSubtrair(int a, int b, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoDaCalculadora = calculadora.subtrair(a, b);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int a, int b, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoDaCalculadora = calculadora.multiplicar(a, b);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int a, int b, int resultado)
        {
            Calculadora calculadora = construirClasse();

            int resultadoDaCalculadora = calculadora.dividir(a, b);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Fact]
        public void TesteDivisaoPorZeroLançarExcecao()
        {
            Calculadora calculadora = construirClasse();

            Assert.Throws<DivideByZeroException>(
                   () => calculadora.dividir(3, 0)
            );
        }

        [Fact]
        public void TesteHistoricoNaoVazio()
        {
            Calculadora calculadora = construirClasse();

            calculadora.somar(1, 2);
            calculadora.subtrair(2, 1);
            calculadora.multiplicar(1, 2);

            var lista = calculadora.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
