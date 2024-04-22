namespace _21Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Emp[] emps = new Emp[3];
            for (int i = 0; i < emps.Length; i++)
            {
                Emp emp = new Emp();
                Console.WriteLine("Enter Id :");
                emp.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name :");
                emp.Name  = Console.ReadLine();
                Console.WriteLine("Enter Address :");
                emp.Address =  Console.ReadLine();
                emps[i] = emp;
            }
            Console.WriteLine("Enter ID whose details you want: ");
            int id=Convert.ToInt32(Console.ReadLine());
            foreach (Emp emp in emps)
            {
              if (emp.Id == id)
                {
                    Console.WriteLine(emp.GetEmpDetails());
                    break;
                }
            }
            Console.ReadLine();
        }
    }
    public class Emp
    {
        private int _EId;
        private string _EName;
        private string _EAddress;

        public string Address
        {
            get { return  _EAddress; }
            set { _EAddress = value; }
        }


        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
        }


        public int Id
        {
            get { return _EId; }
            set { _EId = value; }
        }

        public string GetEmpDetails()
        {
            return string.Format("Id ={0}, Name ={1}, Address ={2}", _EId, _EName, _EAddress);
        }

    }
}
