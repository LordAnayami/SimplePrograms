using System;
using System.Collections.Generic;
using System.Text;

namespace OddNumbers2
{
    public interface ISaveable
    {
        void Save();
    }

    public class Catalog : ISaveable
    {
        void ISaveable.Save()
        {
            Console.WriteLine("Saved");
        }
    }
}
