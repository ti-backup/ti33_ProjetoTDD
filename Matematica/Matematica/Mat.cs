using System;

namespace Matematica
{
    public class Mat
    {
        public static string msgErroRaizValorNegativo = "Não existe solução no conjunto dos Reais.";

        public double RaizQuadrada(double entrada)
        {
            if (entrada < 0)
                throw new ArgumentOutOfRangeException("entrada", entrada, msgErroRaizValorNegativo);

            return Math.Pow(entrada, 1.0 / 2.0);
        }

        public double MediaAritmetica(double[] numeros)
        {
            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            return soma / (double) numeros.Length;
        }
    }
}
