using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.Entities;
using InterfaceAbstractDemo2.MernisServiceReference;

namespace InterfaceAbstractDemo2.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            //Mernis'e çok bağlılık gerektirdiği için böyle kullanmıyoruz. Mernis yoksa sistem tıkanır.
            return true;
        }
    }
}
