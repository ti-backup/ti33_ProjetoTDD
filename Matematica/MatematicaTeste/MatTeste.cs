using Matematica;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatematicaTeste
{
    [TestClass]
    public class MatTeste
    {
        [TestMethod]
        public void RaizQuadradaBasicaTeste()
        {
            Mat m = new Mat();
            double esperado = 2.0;
            double entrada = esperado * esperado;
            double resultadoReal = m.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, resultadoReal, esperado / 100);
        }

        [TestMethod]
        public void RaizQuadradaInteiroPositivoTeste()
        {
            Mat m = new Mat();
            double esperado = 5.0;
            double entrada = esperado * esperado;
            double resultadoReal = m.RaizQuadrada(entrada);

            Assert.AreEqual(esperado, resultadoReal, esperado / 100);
        }
    }
}
