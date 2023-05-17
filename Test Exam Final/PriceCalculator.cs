namespace Test_Exam_Final
{
    public class Prisberegner
    {

        static int CalculatePrice(int area)
        {

            int kmprice = 500; //starting fee

            if (area < 100)
            {
                kmprice += area * 20;
            } else if (area < 200)
            {
                kmprice += (area-100) * 15;
                kmprice += 2000;
            } else if (area < 500)
            {
                kmprice = (area - 200) * 10;
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
