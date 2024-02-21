using DTO;

namespace Repository.Contract
{
    public interface ILoveInfoRepository
    {
        public LoveInfo Query(IWebHostEnvironment env);
        public void Save(IWebHostEnvironment env, LoveInfo info);
    }
}