using System;

namespace PrimeServices
{
    public class PrimeService
    {
        public string ContrataFuncionario(int idade)
        {
            if (idade < 16)
            {
                return "Não contratamos";
            }

            if (idade <= 18)
            {
                return "Contrato de tempo parcial";
            }

            if (idade <= 55)
            {
                return "Contrato de tempo integral";
            }

            return "Não contratamos";
        }
    }
}