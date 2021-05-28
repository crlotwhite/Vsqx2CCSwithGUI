namespace Vsqx2CCS
{
    class BaseTick
    {
        private const int VOCALOID3_TIME_RESOLUTION = 480;
        private const int CEVIO_TIME_RESOLUTION = 960;
        private const int START_TICK = 3840;
        private const int SHIFT_OCTAVE = -1;
        private const int CENTER_NOTE_NUMBER = 64;

        private const string CCS_CODE = "7251BC4B6168E7B2992FA620BD3E1E77";

        public int GetV3Tick()
        {
            return VOCALOID3_TIME_RESOLUTION;
        }

        public int GetCeVIOTick()
        {
            return CEVIO_TIME_RESOLUTION;
        }

        public int GetDifference()
        {
            return CEVIO_TIME_RESOLUTION / VOCALOID3_TIME_RESOLUTION;
        }

        public int GetTimeRes()
        {
            return CEVIO_TIME_RESOLUTION;
        }

        public int GetStartTick()
        {
            return START_TICK;
        }

        public int GetShiftOctave()
        {
            return SHIFT_OCTAVE;
        }

        public int GetCenterNoteNum()
        {
            return CENTER_NOTE_NUMBER;
        }

        public string GetCode()
        {
            return CCS_CODE;
        }
    }
}
