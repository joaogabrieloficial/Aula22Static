namespace Aula22Statisc
{
    public  static class Conversor
    {
        public static  float CotacaoDolar = 5.35f;

        public static float CotacaoEuro = 5.88f;

        public static float RealParaDolar(float valorRS ){
           return valorRS / CotacaoDolar ;
        }

        public static float DolarParaReal(float ValorUS){
            return CotacaoDolar * ValorUS ; 
        }

        public static float RealParaEuro(float valorRS){
            return valorRS / CotacaoEuro;
        }

        public static float EuroParaReal(float ValorEU){
            return CotacaoEuro * ValorEU;
        }
    }
}