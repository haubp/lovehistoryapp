namespace DTO
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
    }
}

