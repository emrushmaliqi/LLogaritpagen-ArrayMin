using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlogaritPagen;
class Employee
{
    public int Id;
    public string Emri;
    public string Pozita;

    public double Rroga;

    public Employee(int id, string emri, string pozita, double rroga)
    {
        Id = id;
        Emri = emri;
        Pozita = pozita;
        Rroga = rroga;
    }

    public virtual double CalculateBonus(double rroga)
    {
        return 0;
    }

}
