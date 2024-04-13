using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvTest
{
    public class Organization
    {
        public string Name { get; } = "Orbiters";
        public string LegalAddress { get; } = "123 Main St, Anytown, USA";
        public string ActualAdress { get; } = "123 Main St, Anytown, USA";

        public Organization(string name, string legalAddress, string actualAddress)
        {
            Name = name;
            LegalAddress = legalAddress;
            ActualAdress = actualAddress;
        }
    }
}
