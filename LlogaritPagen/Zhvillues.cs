using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlogaritPagen;
class Zhvillues : Employee
{
    public Zhvillues(int id, string emri, string pozita, double rroga): base(id, emri, pozita, rroga)
    { 

    }

    public override double CalculateBonus(double rroga)
    {
        double bonus = rroga * 0.2;

        if(bonus < 50000)
        {
            return 50000;
        }

        return bonus;
        
    }
}
