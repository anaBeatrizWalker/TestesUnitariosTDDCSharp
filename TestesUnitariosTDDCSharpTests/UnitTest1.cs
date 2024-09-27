using System;
using TestesUnitariosTDDCSharp;
using Xunit;

namespace TestesUnitariosTDDCSharpTests
{
    public class UnitTest1
    {
        [Fact]
        public void TesteSomarUmConjunto()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.somar(1, 2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        public void TesteSomarVariosConjuntos(int a, int b, int resultado)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoDaCalculadora = calculadora.somar(a, b);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(6, 5, 1)]
        public void TesteSubtrair(int a, int b, int resultado)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoDaCalculadora = calculadora.subtrair(a, b);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int a, int b, int resultado)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoDaCalculadora = calculadora.multiplicar(a, b);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int a, int b, int resultado)
        {
            Calculadora calculadora = new Calculadora();

            int resultadoDaCalculadora = calculadora.dividir(a, b);

            Assert.Equal(resultado, resultadoDaCalculadora);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Calculadora calculadora = new Calculadora();

            Assert.Throws<DivideByZeroException>(
                   () => calculadora.dividir(3,0)
            );
        }

        [Fact]
        public void TesteHistoricoNaoVazio()
        {
            Calculadora calculadora = new Calculadora();

            calculadora.somar(1, 2);
            calculadora.subtrair(2, 1);
            calculadora.multiplicar(1, 2);

            var lista = calculadora.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(4, lista.Count);
        }
    }
}
