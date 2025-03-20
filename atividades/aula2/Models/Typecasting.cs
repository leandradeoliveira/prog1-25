namespace aula2.Models
{
    public class Typecasting
    {
        // decaramo variaveis na calsse 
        public int myInterger = 20;
        public long myLong;

        public string myType1;
        public string myType2;


        public Typecasting() {
            //conversao implicita de tipos 
            myLong = myInterger;
            //myInterger = myLong;
            //neste caso o long e muito grande para 
            // para o int e a conversaco implicitanao e permitida

            // conversao explicita 
            long myLong2 = 1382910;
            int myInterger2;
            myInterger2 = (int)myLong2;


            // e possivel identificar qual e o tipo de uma variavel em tempo de execucao 

            myType1 = myLong2.GetType().ToString();
            myType2 = myInterger2.GetType().ToString();

    }

    }
}
