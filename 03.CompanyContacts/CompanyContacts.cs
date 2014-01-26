using System;
//3.A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

class CompanyContacts
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string name = Console.ReadLine();
        Console.Write("Enter company address: ");
        string address = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter company website: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter manager years: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number: ");
        string managerPhoneNum = Console.ReadLine();
        Console.WriteLine("Company name: {0}\nCompany address: {1}\nCompany phone number: {2}\nCompany fax number: {3}\nCompany website: {4}\nManager Name: {5} {6}\nAge: {7}\nPhone number: {8}\n", name, address, companyPhoneNumber, faxNumber, webSite, firstName, lastName, age, managerPhoneNum);
    }
}
