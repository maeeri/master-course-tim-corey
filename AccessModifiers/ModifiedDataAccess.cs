using AMDemoLibrary;

namespace AccessModifiers
{
    public class ModifiedDataAccess : DataAccess
    {
        public string GetUsecureConnectionInfo()
        {
            return GetConnectionString();
        }
    }
}
