using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IServiceManager
    {
        IAgencyService AgencyService { get; }
        ICityService CityService { get; }
        IClientService ClientService { get; }
        IGarageService GarageService { get; }
        IMotorcycleService MotorcycleService { get; }
        IPhonesServices PhonesServices { get; }
        IRentService RentService { get; }

    }
}
