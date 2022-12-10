namespace Service.Contracts
{
    public interface IServiceManager
    {
        IAgencyService AgencyService {get;}
        ICityService CityService { get; }
        IClientService ClientService { get; }

    }
}
