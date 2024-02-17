using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000.5;

//Variables --> camelCase

bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton --> Hoş Geldin Onur");
}
else
{
    Console.WriteLine("Buton --> Sisteme Giriş Yap");
}

string[] loans = {"Kredi 1","Kredi 2","Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; //db üzerinden gelir JSON vb.
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

    //start     condition         increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new();
Course[] courses2= courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name
        + " / " + courses2[i].Price);
}

Console.WriteLine("Kod Bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Test FirstName";
customer1.LastName = "Test LastName";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "5678965412";
customer2.FirstName = "Ali FirstName";
customer2.LastName = "Veli LastName";
customer2.CustomerNumber = "123457";


CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";


CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";


BaseCustomer[] customers = {customer1, customer2,customer3,customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    //if (customer is IndividualCustomer)
    //{
    //    int a =((IndividualCustomer)customer).Id;
    //}
    Console.WriteLine(customer.CustomerNumber);
}

