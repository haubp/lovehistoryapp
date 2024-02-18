using System.IO;
using System.Text.Json;

namespace Model
{
    public class LoveInfo
    {
        public bool isArgue { get; set; }
        public string startDatingDate { get; set; }
        public string startArgueDate { get; set; }
        public ulong totalArgueTime { get; set; }
        public LoveInfo() {
            isArgue = false;
            startDatingDate = "2022-03-12";
            startArgueDate = "2021-01-01";
            totalArgueTime = 0;
        }
        public LoveInfo(string infoFilePath)
        {
            if (File.Exists(infoFilePath))
            {
                string jsonText = File.ReadAllText(infoFilePath);

                LoveInfo loveInfoFromJson = JsonSerializer.Deserialize<LoveInfo>(jsonText);

                isArgue = loveInfoFromJson.isArgue;
                startDatingDate = loveInfoFromJson.startDatingDate;
                startArgueDate = loveInfoFromJson.startArgueDate;
                totalArgueTime = loveInfoFromJson.totalArgueTime;
            }
            else
            {
                throw new FileNotFoundException($"File {infoFilePath} does not exist.");
            }
        }
        public void SaveToFile(string infoFilePath)
        {
            string jsonText = JsonSerializer.Serialize(this);

            File.WriteAllText(infoFilePath, jsonText);
        }
    }
}

