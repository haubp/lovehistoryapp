using Repository.Contract;
using Repository.LocalFS;

namespace  Repository.Factory
{
    public class LoveInfoFactory
    {
        public static ILoveInfoRepository CreateLoveInfoRepository()
        {
            return new LoveInfoLocalFS();
        }
    }
}
