// See https://aka.ms/new-console-template for more information
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrate;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth=new DateTime(1999,01,14),FirstName="Mustafacan",LastName="ALTUNCU",NationalityId="31741018702", });
        }
    }
}
