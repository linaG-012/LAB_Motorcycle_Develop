namespace Contracts
{
    public interface IRepositoryManager
    {
        IAgencyRepository Agency { get; }
        IClientRepository Client { get; }
        ICityRepository City { get; }

        void Save();
    }
}
