namespace Aula22
{
    public static class Conversor
    {
        public static float CotacaoDolar = 5.24f;
        public static float CotacaoEuro = 5.90f;

        public static float ConverterRealParaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }
        public static float ConverterDolarParaReal( float valorRS ){
            return CotacaoDolar * valorRS;
        }

        public static float ConverterEuroParaReal(float valorRS){
            return CotacaoEuro * valorRS;
        }

        public static float ConverterRealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }
    }
}