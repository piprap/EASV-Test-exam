namespace Test_Exam_Final
{
    public class Prisberegner
    {

        static int CalculatePrice(int area)
        {

            int kmprice = 500; //starting fee

            if (distance < 100)
            {
                kmprice += distance * 20;
            } else if (distance < 200)
            {
                kmprice += (distance-100) * 15;
                kmprice += 2000;
            } else if (distance < 500)
            {
                kmprice = (distance - 200) * 10;
                kmprice += 3500;
            }

            Console.WriteLine(kmprice);

            //price1 = 100
            //price2 = 
            //price3 = 

            //modes: 
            //No multiplier = 000
            //Imprægnering  = 100
            //DoubleVask    = 010
            //Both          = 001
            return kmprice;
        }
    }
}
