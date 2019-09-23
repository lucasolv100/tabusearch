namespace TabuSearch
{
    public static class Shopping
    {
        public static double ObjectiveFunction(int[] solucao)
        {
            double[] valores = new double[] { 1.1, 1.2, 1.25, 1.41, 1.5, 1.63, 2.05, 2.22, 2.65, 2.9, 3.04, 3.16 };
            double soma = 0;
            double produto = 1;

            for (int i = 0; i < valores.Length; i++)
            {
                if (solucao[i] == 1)
                {
                    soma = soma + valores[i];
                    produto = produto * valores[i];
                }
            }

            if (soma == 7.11 && produto == 7.11)
            {
                return 7.11;
            }
            else
            {
                return 0;
            }
        }
    }
}