using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities;

internal class IndividualCustomer:BaseCustomer // Bireysel Müşteri
{
    //public int Id { get; set; }
    //public string CustomerNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
}
