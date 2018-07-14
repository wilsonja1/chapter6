using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter6
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public const int CostOfFoodPerPerson = 25;

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }

        virtual public decimal Cost
        {
            get
            {
                
            }
        }
    }
}
