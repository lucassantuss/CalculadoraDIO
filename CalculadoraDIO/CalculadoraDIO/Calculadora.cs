﻿namespace CalculadoraDIO
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }

        public int Subtrair(int valor1, int valor2)
        {
            int resultado = valor1 - valor2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }

        public int Dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            int resultado = valor1 * valor2;
            listaHistorico.Insert(0, "Resultado: " + resultado + " - Data: " + data);

            return resultado;
        }

        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count() - 3);

            return listaHistorico;
        }
    }
}