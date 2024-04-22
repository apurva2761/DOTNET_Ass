using System.Diagnostics;

namespace _03interface
{
    internal class Ass2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("which card you have :");
            Console.WriteLine("1.silver_card, 2.gold_card ,3.Platinum_card");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Facilities you will be getting are as follows :");
            switch (choice)
            {
                case 1:
                    Ix i = new Platinum();
                    i.Online_Shopping();
                    i.Max_Cashback();
                    break;

                case 2:
                    Iy j = new Platinum();
                    j.Online_Shopping();
                    j.Max_Cashback();
                    j.Higher_Debit_Card_Limits();

                    break;
                case 3:
                    Platinum p = new Platinum();
                    p.Online_Shopping();
                    p.Max_Cashback();
                    p.Higher_Debit_Card_Limits();
                    p.Insurance_Cover();
                    p.Max_Cashback();
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
        public interface Ix
        {
            public void Online_Shopping();
            public void Max_Cashback();
        }
        public interface Iy
        {
            public void Online_Shopping();
            public void Max_Cashback();
            public void Higher_Debit_Card_Limits();
        }


        public class Platinum : Ix, Iy
        {
            void Ix.Online_Shopping()

            {
                Console.WriteLine("Online_Shopping =  you have 20% discount on online shopping  ");
            }
            void Iy.Online_Shopping()

            {
                Console.WriteLine("\n Online_Shopping = you have 40% discount on online shopping");
            }
            void Ix.Max_Cashback()
            {
                Console.WriteLine("\n Max_Cashback = You will get upto Rs. 150 per month .");

            }
            void Iy.Max_Cashback()
            {
                Console.WriteLine("\n Max_Cashback =  You will get upto Rs. 350 per month .  ");
            }
            void Iy.Higher_Debit_Card_Limits()
            {
                Console.WriteLine("\n Higher_Debit_Card_Limits = Daily Domestic Shopping limits: Rs. 2 lacs  ");
            }
            public void Online_Shopping()

            {
                Console.WriteLine("\n Online_Shopping =  you have 50% discount on online shopping  ");
            }
            public void Higher_Debit_Card_Limits()
            {
                Console.WriteLine("\n Higher_Debit_Card_Limits = Daily Domestic Shopping limits: Rs. 5 lacs  ");
            }
            public void Insurance_Cover()
            {
                Console.WriteLine("\n Insurance_Cover =  Death Cover by Air / Road / Rail-Sum Insured up to Rs. 12,00,000.");
            }
            public void Max_Cashback()
            {
                Console.WriteLine("\n Max_Cashback = You will get upto Rs. 750 per month .");
            }

        }

    }
}
