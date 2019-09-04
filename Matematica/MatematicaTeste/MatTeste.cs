using Matematica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestMethod]
        public void RaizQuadradaValorNegativoTeste()
        {
            Mat m = new Mat();
            double entrada = -1.0;

            try
            {
                m.RaizQuadrada(entrada);
            }
            catch (ArgumentOutOfRangeException ae)
            {
                StringAssert.Contains(ae.Message, Mat.msgErroRaizValorNegativo);
                return;
            }

            Assert.Fail("O método não lançou a exceção esperada");
        }

        [TestMethod]
        public void MediaAritmeticaVetorComDoisValores()
        {
            Mat m = new Mat();
            double[] numeros = new double[2];
            numeros[0] = 5.0;
            numeros[1] = 7.0;

            double valorEsperado = 6.0;
            double valorReal = m.MediaAritmetica(numeros);

            Assert.AreEqual(valorEsperado, valorReal, 0.01);
        }
    }
}
