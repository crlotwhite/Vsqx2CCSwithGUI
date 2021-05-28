using System;
using System.Collections;
using System.Windows.Forms;

namespace Vsqx2CCS
{
    class NoteData
    {
        // ノートナンバーの範囲
        private const int NOTENUM_MAX = 127;
        private const int NOTENUM_MIN = 0;
        private const int DODECAPHONISM = 12;

        // ノートナンバー・歌詞
        private int noteNum;
        private string lyric;

        // ノートの開始位置・デュレーション
        private int position1;
        private int position2;
        private string beginPos;
        private string duration;
        private TimeSpan playTime;

        // CeVIOでのノートナンバー
        private int pitchStep;
        private int pitchOctave;

        private BaseTick deff = new BaseTick();

        // 初期設定
        public NoteData()
        {
            noteNum = deff.GetCenterNoteNum();
            lyric = "a";
            beginPos = "0";
            duration = deff.GetCeVIOTick().ToString();
            pitchStep = 5;
            pitchOctave = 0;
        }

        // 歌詞をセット
        public void SetNoteLyric(string vsqxLyric)
        {
            lyric = vsqxLyric;
        }

        // ノートナンバーをセット
        public void SetNoteNum(int vsqxNoteNum)
        {
            noteNum = vsqxNoteNum;
            SetTick(noteNum);
        }

        // ノートの開始位置をセット
        public void SetBeginTick(string vsqxBegin)
        {
            // CeVIOでの処理のため2倍 + 開始値
            position1 = int.Parse(vsqxBegin) * deff.GetDifference() + deff.GetStartTick();
            beginPos = position1.ToString();
        }

        // ノートのデュレーションをセット
        public void SetDuration(string vsqxDuration)
        {
            // CeVIOでの処理のため補正
            position2 = int.Parse(vsqxDuration) * deff.GetDifference();
            duration = position2.ToString();
        }

        // ノートナンバーからCeVIOでの音階をセットする
        public void SetTick(int noteNum)
        {
            // ノートナンバーが範囲外なら範囲内部にする
            if (noteNum > NOTENUM_MAX) noteNum = NOTENUM_MAX;
            if (noteNum < NOTENUM_MIN) noteNum = NOTENUM_MIN;

            // 音階調整
            pitchOctave = noteNum / DODECAPHONISM + deff.GetShiftOctave();
            pitchStep = noteNum % DODECAPHONISM;
        }

        public string GetLyric()
        {
            return lyric;
        }

        public string GetNoteNum()
        {
            return noteNum.ToString();
        }

        public string GetClock()
        {
            return beginPos.ToString();
        }

        public string GetDuration()
        {
            return duration.ToString();
        }

        public string GetPitchOctave()
        {
            return pitchOctave.ToString();
        }

        public string GetPitchStep()
        {
            return pitchStep.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void SetPlayTime(string currentPartTick)
        {
            playTime = new TimeSpan(int.Parse(currentPartTick));
        }

        public string GetPlayTime()
        {
            MessageBox.Show(playTime.TotalHours.ToString() + ":" + playTime.TotalMinutes.ToString() + ":" + playTime.TotalSeconds.ToString());
            return playTime.TotalHours.ToString() + ":" + playTime.TotalMinutes.ToString() + ":" + playTime.TotalSeconds.ToString();
        }
    }
}
