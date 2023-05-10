using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlogaritPagen;
internal class Admin : Employee
{
    public Admin(int id, string emri, string pozita, double rroga) : base(id, emri, pozita, rroga)
    {

    }

    public override double CalculateBonus(double rroga)
    {
        return 50000;
    }
}
