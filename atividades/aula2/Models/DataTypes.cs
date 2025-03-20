namespace aula2.Models
{
    public class DataTypes
    {
        public char myVar = 'a';
        public const char myConst = 'b';

        public const char myChar1 = 'f';
        public char myChar3 = 'x';

        public  char myChar4 = '\u2726';

        // podemos ainda mesclar caracateres espacias 
        //como nova linha tabulacao etc 

        string textLine = "Esta e uma linha de texto .\n\n\n";
            /*
             \e caractere de scape 
            \n nova linha 
            \r retorno 
            \t tabulacao horizontal 
            \" aspas duplas usadas para exebir aspas dentor da string 
            \' usada para exibir aspas simoles na string

             */
       // interpolacao de string
       // combinando string de diferentes maneiras no c#

            private int count = 10;
        public string message;

            
            
            public DataTypes ()
        {
            message = $"o contador em {count}";
            string username = "Leandra";
            int inboxCount = 10;
            int maxCount = 100;
            message += $"\n o usuario {username} tem {inboxCount} messagens.";
            message+= $"\n Espaco restante em sua caixa {maxCount - inboxCount}.";
      
}  
