namespace Vsqx2CCS
{
    class BpmData
    {
        private string tempo;
        private int clock;
        private string integerPoint;
        private string decimalPoint;

        private BaseTick deff = new BaseTick();

        public void SetTempo(string currentBpm)
        {
            tempo = currentBpm;
        }

        public void SetClock(string currentClock)
        {
            clock = int.Parse(currentClock) * deff.GetDifference() / 2 + deff.GetStartTick();
        }

        public void SetIntegerPoint(string currentInteger)
        {
            integerPoint = currentInteger;
        }

        public void SetDecimalPoint(string currentDecimalPoint)
        {
            decimalPoint = currentDecimalPoint;
        }

        public string GetTempo()
        {
            return tempo;
        }

        public string GetClock()
        {
            return clock.ToString();
        }

        public string GetIntegerPoint()
        {
            return integerPoint;
        }

        public string GetDecimalPoint()
        {
            return decimalPoint;
        }
    }
}
