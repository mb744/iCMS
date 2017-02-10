using DDDPizza.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCMS.DomainModels
{
    public class Case : ValueObject<Case>
    {
        public Client Client { get; set;}
        public List<Providers> Providers { get; set; }
        public 
    }
}
