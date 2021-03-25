using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(); eğer böyle tanımlarsan Mernis sitesinde bağımlı hale gelirsin.
                                                                                                                  //site içeriği veya kendisi değişirse sıkıntı



            return true;
        }


    }
}
