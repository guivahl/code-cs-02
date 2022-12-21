namespace ex01;
class Program
{
    static void Main(string[] args)
    {  
        System.Console.WriteLine(funcaoRetornaQuantitadePOV(0.1M, 90));
        System.Console.WriteLine(funcaoRetornaQuantitadePOV(0.1M, 100));
        System.Console.WriteLine(funcaoRetornaQuantitadePOV(0.2M, 70));
        System.Console.WriteLine(funcaoRetornaQuantitadePOV(1M, 70));
    }

    public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado) {
            if (porcentagem >= 1M || porcentagem < 0) return 0;
            if (totalNegociado < 0) return 0;

            decimal executado = totalNegociado * porcentagem;
            decimal porcComplementar = 1 - porcentagem;
            
            return (int) Math.Floor(executado / porcComplementar);
    }
}
