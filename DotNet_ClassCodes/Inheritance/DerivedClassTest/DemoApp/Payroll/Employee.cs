namespace Payroll
{
    class Employee
    {
        private int hours;
        private float rate;
        private static int count; //value will be shared by all instances

        public Employee(int h, float r)
        {
            hours = h;
            rate = r;
            count += 1;
        }

        public Employee() : this(0, 0) {}

        //property member includes accessor (get/set) methods which
        //can be called using field-access syntax
        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public float HourlyRate
        {
            get { return rate; }
            set { rate = value; }
        }

        //overridable method
        public virtual double Income()
        {
            double income = hours * rate;
            int ot = hours - 180;
            if(ot > 0)
                income += 50 * ot;
            return income;
        }

        //can be called on the class
        public static int CountInstances()
        {
            return count;
        }

    }
}