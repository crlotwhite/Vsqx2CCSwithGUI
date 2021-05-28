using System;
using System.Collections.Generic;

namespace Vsqx2CCS
{
    class TrackData
    {
        private string trackName;
        private List<NoteData> note;

        private int trackNum;

        private int mute;
        private int solo;
        private int volume;

        // トラックとミキサー識別用のGUID
        private Guid guidValue;

        // インスタンス作成時にトラックとミキサーの識別用GUIDを作成する
        public TrackData()
        {
            NoteData note = new NoteData();
            guidValue = Guid.NewGuid();
        }

        public string GetTrackGuid()
        {
            // ハイフンを追加したGUIDを返す
            return guidValue.ToString("D");
        }

        public void SetTrackName(string name)
        {
            trackName = name;
        }

        public string GetTrackName()
        {
            return trackName;
        }

        public void SetMute(int trackMute)
        {
            mute = trackMute;
        }

        public int GetMute()
        {
            return mute;
        }

        public void SetSolo(int trackSolo)
        {
            solo = trackSolo;
        }

        public int GetSolo()
        {
            return solo;
        }

        public void SetVolume(int trackVol)
        {
            volume = trackVol;
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetTrackNum(string track)
        {
            trackNum = int.Parse(track);
        }

        public int GetTrackNum()
        {
            return trackNum;
        }

        public void SetNote(List<NoteData> currentNote)
        {
            note = currentNote;
        }

        public List<NoteData> GetNote()
        {
            return note;
        }
    }
}
