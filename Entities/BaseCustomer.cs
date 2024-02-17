namespace Intro.Entities;

public class BaseCustomer // IndividualCustomer ve CorporateCustomer da ortak olan özellikler
{
    public int Id { get; set; }
    public string CustomerNumber { get; set; }
}
