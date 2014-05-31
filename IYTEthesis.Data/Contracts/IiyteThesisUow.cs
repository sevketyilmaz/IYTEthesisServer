using System;

using IYTEthesis.Model;

namespace IYTEthesis.Data.Contracts
{
    public interface IiyteThesisUow
    {
        //save pending changes to the data store
        void Commit();

        //Repositories
        IRepository<Customer> Customers { get; }
        IRepository<Driver> Drivers { get; }
        IRepository<Owner> Owners { get; }
        IRepository<Vehicle> Vehicles { get; }
        IRepository<OnlineVehicle> OnlineVehicles { get; }
        IRepository<Job> Jobs { get; }
    }
}
