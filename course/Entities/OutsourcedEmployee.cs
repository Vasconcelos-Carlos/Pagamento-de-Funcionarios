using System;
using System.Collections.Generic;
using System.Text;

namespace Herança_Polimosfismo.course.Entities
{
    class OutsourcedEmployee : Employee //A classe "OutsourcedEmployee" está herdadndo da classe "Employee"
    {
        public double AdditionalCharge { get; set; }

        // Contrutor aproveitando todos os parametros do construtor da classe Employee por meio do 'BASE' 
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) :base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
    }
}
