namespace Vsqx2CCS
{
    class BeatData
    {
        private string denomi;  // 分母
        private string nume;    // 分子
        private int posMes;     // テンポチェンジポイント

        private BaseTick deff = new BaseTick();

        public void SetDenomi(string targetDenomi)
        {
            denomi = targetDenomi;
        }

        public string GetDenomi()
        {
            return denomi;
        }

        public void SetNume(string targetNume)
        {
            nume = targetNume;
        }

        public string GetNume()
        {
            return nume;
        }

        public void SetPosMes(int currentPosMes)
        {
            //Console.WriteLine(currentPosMes + "\n" + int.Parse(nume) + "\n" + int.Parse(denomi));
            //posMes = (currentPosMes - int.Parse(nume) / int.Parse(denomi)) * deff.GetStartTick();
            posMes = currentPosMes * deff.GetStartTick() * 4 / 4;// *deff.GetV3Tick();// +deff.GetStartTick();
        }

        public int GetPosMes()
        {
            return posMes;
        }
    }
}
