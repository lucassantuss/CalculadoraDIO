namespace CalculadoraDIO.Tests
{
    public class CalculadoraTests
    {
        public Calculadora ConstruirClasse()
        {
            return new Calculadora("14/04/2024");
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 4, 6)]
        [InlineData(4, 4, 8)]
        [InlineData(5, 3, 8)]
        [InlineData(5, 6, 11)]
        public void Somar(int valor1, int valor2, int resultadoEsperado)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Somar(valor1, valor2);

            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(4, 3, 1)]
        [InlineData(7, 4, 3)]
        [InlineData(9, 3, 6)]
        [InlineData(12, 6, 6)]
        public void Subtrair(int valor1, int valor2, int resultadoEsperado)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Subtrair(valor1, valor2);

            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(4, 2, 2)]
        [InlineData(4, 4, 1)]
        [InlineData(9, 3, 3)]
        [InlineData(8, 2, 4)]
        public void Dividir(int valor1, int valor2, int resultadoEsperado)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Dividir(valor1, valor2);

            Assert.Equal(resultado, resultadoEsperado);
        }

        [Theory]
        [InlineData(1, 3, 3)]
        [InlineData(2, 4, 8)]
        [InlineData(4, 4, 16)]
        [InlineData(5, 3, 15)]
        [InlineData(5, 6, 30)]
        public void Multiplicar(int valor1, int valor2, int resultadoEsperado)
        {
            Calculadora calc = ConstruirClasse();

            int resultado = calc.Multiplicar(valor1, valor2);

            Assert.Equal(resultado, resultadoEsperado);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            List<string> lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}