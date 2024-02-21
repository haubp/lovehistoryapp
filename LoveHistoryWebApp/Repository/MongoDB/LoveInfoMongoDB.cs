using DTO;
using Repository.Contract;

namespace Repository.MongoDB
{
    public class LoveInfoMongoDB : ILoveInfoRepository
    {
        public LoveInfo Query(IWebHostEnvironment env)
        {
            return new LoveInfo();
        }
        public void Save(IWebHostEnvironment env, LoveInfo info)
        {
        }
    }
}