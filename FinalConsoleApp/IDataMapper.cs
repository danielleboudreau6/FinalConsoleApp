using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    // generic type parameter that allows you to specify an arbitrary type to a method at compile-time, without specifying a concrete type in the method class declaration. 
    internal interface IDataMapper<T>
    {
        List<T> Select();
        List<T> Find(string LastName); // loosely uncoupling

    }
}
