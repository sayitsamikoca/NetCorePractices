using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Concrete;
using static MernisServiceReference.KPSPublicSoapClient;
using MernisServiceReference; 


namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            long nationalityNumber = Convert.ToInt64(customer.NationalityId);

            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(nationalityNumber,
                customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.DateOfBirth.Year);

            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
