namespace Assignment1
{
    internal class EmployeeMain
    {
        static void Main(string[] args)
        {
           Employee e1= new Employee(Name:"nitesh",Basic:25000);
            Console.WriteLine("employee no: "+e1.EmpNo+"| name: "+e1.Name+"| Dept No: "+e1.DeptNo+"| Basic: "+e1.Basic+"| net salary : "+e1.getNetSal() );

            
           
        } 
    }

    public class Employee
    {
        private String name;
       public  String Name
        {
            set
            {
                if (value != null)
                {
                    name = value;   

                }
                else
                {
                    Console.WriteLine("Name can't be null");
                }
            }
            get { 
            return name;    
            }
        }
        private int empNo;
        public int EmpNo
        {
            set {
                if (value > 0)
                {
                    empNo = value;  
                }
                else
                {
                    Console.WriteLine("EmpNo must be greater than 0");
                }
               
            }
            get { 
            return empNo;   
            }
        }



        private decimal basic;

        public decimal Basic
        {
            set {
                if (value <= 30000 && value >= 20000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("enter value between 20000 to 30000");
                }
            }
            get
            {
                return basic;
            }
        }
        
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if(value>0){
                    deptNo = value;

                }
                else
                {
                    Console.WriteLine("DeptNo cant be less than 0");
                }
            }
            get { return deptNo; }  
        }


       public  Employee(int EmpNo=1,String Name="n",short DeptNo=1,decimal Basic=20000)
        {
            this.EmpNo = EmpNo;
           this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo; 
        }

        public decimal getNetSal()
        {
            return basic * 12;
        }

        

    }

}
