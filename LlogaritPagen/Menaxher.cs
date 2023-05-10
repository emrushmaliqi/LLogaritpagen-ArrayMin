using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlogaritPagen;
internal class Menaxher : Employee
{
    public Menaxher(int id, string emri, string pozita, double rroga) : base(id, emri, pozita, rroga)
    {

    }

    public override double CalculateBonus(double rroga)
    {
        double bonus = rroga * 0.25;

        if (bonus < 50000)
        {
            return 50000;
        }

        return bonus;
    }
}
