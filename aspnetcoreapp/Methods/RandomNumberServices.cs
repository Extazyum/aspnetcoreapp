using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapp.Methods
{
    public class RandomNumberService
    {
        public  int GetNext() => new Random().Next();
    }
}
