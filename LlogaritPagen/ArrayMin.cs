using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlogaritPagen;

class ArrayMin
{
    private int[] _array;

    public void InitializeArray()
    {
        do
        {
            Console.Write("Enter amount of numbers: ");
            if (int.TryParse(Console.ReadLine(), out var length) && length > 0){
                _array = new int[length];
            }
        } while (_array is null);


    }

    public void InsertNumbers()
    {
        if (_array is null)
        {
            Console.WriteLine("Please initialize array first!");
            return;
        }

        for (int i = 0; i < _array.Length; i++)
        {

            int parsedNum;
            do
            {
                Console.Write($"Enter {i + 1}st/nd/rd/th number: ");
            } while (!int.TryParse(Console.ReadLine(), out parsedNum));
            
            _array[i] = parsedNum;
        }
    }

    public int Min()
    {
        if ( _array is null)
        {
            throw new Exception("You need to initialize array first");
        }

        var minValue = _array[0];

        for (var i = 1; i < _array.Length; i++)
        {
            if (minValue > _array[i])
            {
                minValue = _array[i];
            }
        }

        return minValue;

    }
}
