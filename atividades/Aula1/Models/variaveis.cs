namespace Aula1.Models
{
    public class variaveis
    {

        //tipos implicitos

        //anotacao de tipos 

        public int userCount = 10;
        
        // uma variavel pode  ser declarada e nao inicializado 
        int totalCount;

        // o metodo construtor e invocado na instanciacao do
        // objete por meio da palavra reservads new 
        // por regra o construtor sempre trem o mesmo nome da classe 
        //
         public variaveis ()
        {

            var teste = 10;
            totalCount = 0;

            // TIPO IMPLICITO
            // a palavra cahave var se encarega de definir o
            // tipo da variavel na instrucao de atrubuicao
            // para declarar uma constant usamos a palavra chave const
            //no entanto a const deve ser  inicializada quando declarada 
            
            const int intrestRate = 10;
            // atividade 

            byte MinValue = 0;
            byte MaxValue = 255;

            short MaxValue1 = 32767;

            int MinValue2 = -2147483648;
            int MaxValue2 = 2147483647;

            uint MinValue3 = 0;
            uint MaxValue3 = 4294967295;

            long MinValue4 = -9223372036854775808;
            long MaxValue4 = 9223372036854775807;


            var signalStrangth = 22;
            var companyName = "ACNE";


        }

    }
}
