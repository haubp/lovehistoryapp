using DTO;
using Repository.Contract;

namespace Repository.PostgresDB
{
    public class LoveInfoPostgresDB : ILoveInfoRepository
    {
        public LoveInfo Query(IWebHostEnvironment env)
        {
            throw new NotImplementedException();
        }
        public void Save(IWebHostEnvironment env, LoveInfo info)
        {
            throw new NotImplementedException();
        }
    }
}