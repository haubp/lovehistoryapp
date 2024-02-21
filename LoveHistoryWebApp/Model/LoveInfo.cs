using Repository.Contract;
using Repository.Factory;
using DTO;

namespace Model
{
    public class LoveInfoModel {
        public static LoveInfo Query(IWebHostEnvironment env) {
            ILoveInfoRepository loveInfoRepository = LoveInfoFactory.CreateLoveInfoRepository();
            return loveInfoRepository.Query(env);
        }
        public static void Save(IWebHostEnvironment env, LoveInfo info) {
            ILoveInfoRepository loveInfoRepository = LoveInfoFactory.CreateLoveInfoRepository();
            loveInfoRepository.Save(env, info);
        }
    };
}

