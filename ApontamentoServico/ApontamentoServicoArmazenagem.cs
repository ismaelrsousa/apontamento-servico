namespace ApontamentoServico
{
    public class ApontamentoServicoArmazenagem : ApontamentoServicoBase
    {
        public override decimal Valorar()
        {
            decimal valor = 300;
            Console.WriteLine("Valorando serviço de ARMAZENAGEM");
            return valor;
        }

        public override bool Apontar()
        {
            // decimal dias = ObterDiasArmazenados(entrada, saida);

            Console.WriteLine($"Apontando serviço de ARMAZENAGEM - {2} DIAS ARMAZENADOS");

            return true;
        }

        public virtual decimal ObterDiasArmazenados(DateTime entrada, DateTime saida)
        {
            if (saida > entrada)
                throw new Exception("Saída não pode ser maior que a entrada");

            return saida.Subtract(entrada).Days;
        }
    }
}
