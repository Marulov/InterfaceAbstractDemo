using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new NeroCustomerManager();
            baseCustomerManager.Save(new Customer { DateOfBirth = new DateTime(1999, 2, 16), FirstName = "Nazım", LastName = "Marul", NationalityId = 918624561546 });
            Console.ReadLine();
        }
    }
}
