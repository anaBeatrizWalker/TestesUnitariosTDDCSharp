using System;
using System.Collections.Generic;
using System.Text;

namespace TestesUnitariosTDDCSharp
{
    public class Calculadora
    {
        private List<string> listaHistorico; 

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int somar(int a, int b)
        {
            int resultado = a + b;
            listaHistorico.Insert(0, $"{a} + {b} = {resultado}");
            return resultado;
        }

        public int subtrair(int a, int b)
        {
            int resultado = a - b;
            listaHistorico.Insert(0, $"{a} - {b} = {resultado}");
            return resultado;
        }

        public int multiplicar(int a, int b)
        {
            int resultado = a * b;
            listaHistorico.Insert(0, $"{a} x {b} = {resultado}");
            return resultado;
        }

        public int dividir(int a, int b)
        {
            int resultado = a / b;
            listaHistorico.Insert(0, $"{a} / {b} = {resultado}");
            return resultado;
        }

        public List<string> historico()
        {
            List<string> resultado = new List<string>(listaHistorico);
            return resultado;
        }
    }
}
