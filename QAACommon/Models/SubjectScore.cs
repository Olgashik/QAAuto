namespace QAACommon.Models
{
    internal class SubjectScore
    {
        const short MAX_SCORE = 10;

        private short _score;
        public short Score
        {
            get
            {
                return _score;
            }
            set
            {
                if (value >= 0 && value <= MAX_SCORE)
                {
                    _score = value;
                }
            }
        }


        public string ItemName { get; set; }

        public SubjectScore(short score, string itemName)
        {
            Score = score;
            ItemName = itemName;
        }

    }

}
