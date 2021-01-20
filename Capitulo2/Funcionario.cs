using System;
using System.Globalization;

namespace Capitulo2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - (SalarioBruto * Imposto / 100.00);
        }

        public void AumentarSalario(double aumento)
        {
            SalarioBruto += (SalarioBruto * aumento / 100.00);
        }

        public override string ToString()
        {
            return Nome
                + ", R$"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
