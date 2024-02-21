using DTO;
using Repository.Contract;
using System.Text.Json;
using Constants;

namespace Repository.LocalFS
{
    public class LoveInfoLocalFS : ILoveInfoRepository
    {
        public LoveInfo Query(IWebHostEnvironment env)
        {
            string loveInfoFilePath = Path.Combine(env.WebRootPath, Constant.LoveInfoFileName);
            if (File.Exists(loveInfoFilePath))
            {
                string jsonText = File.ReadAllText(loveInfoFilePath);
                LoveInfo? loveInfoFromJson = JsonSerializer.Deserialize<LoveInfo>(jsonText);

                return loveInfoFromJson ?? new LoveInfo();
            }
            
            throw new FileNotFoundException($"File {loveInfoFilePath} does not exist.");
        }
        public void Save(IWebHostEnvironment env, LoveInfo info)
        {
            string jsonText = JsonSerializer.Serialize(info);
            string loveInfoFilePath = Path.Combine(env.WebRootPath, Constant.LoveInfoFileName);

            File.WriteAllText(loveInfoFilePath, jsonText);
        }
    }
}
