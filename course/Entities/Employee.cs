namespace Herança_Polimosfismo.course.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // Metodo de pagameto
        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }
    }
}
