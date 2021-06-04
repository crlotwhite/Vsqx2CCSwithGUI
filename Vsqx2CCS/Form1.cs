using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Vsqx2CCS
{
    public partial class Form1 : Form
    {
        private readonly String vsqx3Xsd = "vsq3.xsd";

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void btnSelDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPathDestDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void logging(string msg)
        {
            if (!String.IsNullOrEmpty(msg))
            {
                string prev_msg = tbLogs.Text;
                tbLogs.Text = msg + Environment.NewLine + prev_msg;
            }
        }

        private bool ConvertVsqxToCcs(string vsqxFile)
        {
            string[] baseName = { };

            string saveFileName = "";

            const int VS_TRACK_MAX = 16;

            List<TrackData> trackArray = new List<TrackData>();
            List<NoteData>[] noteArray = new List<NoteData>[VS_TRACK_MAX];
            List<BpmData> bpmArray = new List<BpmData>();
            List<BeatData> beatArray = new List<BeatData>();
            BaseTick deff = new BaseTick();

            ArrayList lyricArray = new ArrayList();
            ArrayList posTickArray = new ArrayList();
            ArrayList durationArray = new ArrayList();

            /*
             if (vsqxFiles.Length <= 0)
             {
                 OpenFileDialog openVsqxFileDialog = new OpenFileDialog();
                 // ダイアログのタイトルを設定する
                 openVsqxFileDialog.Title = "ファイルを開く";
                 // 初期表示するディレクトリを設定する
                 openVsqxFileDialog.InitialDirectory = @"C:\";
                 // 初期表示するファイル名を設定する
                 openVsqxFileDialog.FileName = "";
                 // ファイルのフィルタを設定する
                 openVsqxFileDialog.Filter = "VOCALOID3 Sequence|*.vsqx|すべてのファイル|*.*";
                 // ファイルの種類 の初期設定を 2 番目に設定する (初期値 1)
                 openVsqxFileDialog.FilterIndex = 1;
                 // ダイアログボックスを閉じる前に現在のディレクトリを復元する (初期値 false)
                 // openVsqxFileDialog.RestoreDirectory = true;
                 // 複数のファイルを選択可能にする (初期値 false)
                 openVsqxFileDialog.Multiselect = true;
                 // [ヘルプ] ボタンを表示する (初期値 false)
                 openVsqxFileDialog.ShowHelp = false;
                 // [読み取り専用] チェックボックスを表示する (初期値 false)
                 // openVsqxFileDialog.ShowReadOnly = true;
                 // [読み取り専用] チェックボックスをオンにする (初期値 false)
                 // openVsqxFileDialog.ReadOnlyChecked = true;
                 // 存在しないファイルを指定した場合は警告を表示する (初期値 true)
                 //openVsqxFileDialog.CheckFileExists = true;
                 // 存在しないパスを指定した場合は警告を表示する (初期値 true)
                 //openVsqxFileDialog.CheckPathExists = true;
                 // 拡張子を指定しない場合は自動的に拡張子を付加する (初期値 true)
                 openVsqxFileDialog.AddExtension = true;
                 // 有効な Win32 ファイル名だけを受け入れるようにする (初期値 true)
                 //openVsqxFileDialog.ValidateNames = true;
                 // ダイアログを表示し、戻り値が [OK] の場合は、選択したファイルを表示する

                 if (openVsqxFileDialog.ShowDialog() == DialogResult.OK)
                 {
                     Console.WriteLine(openVsqxFileDialog.FileName);
                     vsqxFiles = openVsqxFileDialog.FileNames;
                 }

                 // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
                 openVsqxFileDialog.Dispose();
             }
             */


            baseName = vsqxFile.Split('.');

            if (baseName[baseName.Length - 1] != "vsqx")
            {
                MessageBox.Show("File Error" , $"{vsqxFile} \nNot vsqx.\nSkip\n");
                return false;
            }

            
            /*
            // vsqxのみ処理
            if (baseName[baseName.Length - 1] == "ust" && System.IO.File.Exists(ust2ccs))
            {
                Console.Write(currentFileName + "\nSend to ust2ccs.");
                // TODO:センド処理
                System.Diagnostics.Process pro = new System.Diagnostics.Process();

                pro.StartInfo.FileName               = "cmd.exe";                  // コマンド名
                pro.StartInfo.Arguments              = "/c " + ust2ccs + currentFileName;    // 引数
                pro.StartInfo.CreateNoWindow         = true;                     // DOSプロンプトの黒い画面を非表示
                pro.StartInfo.UseShellExecute        = false;                    // プロセスを新しいウィンドウで起動するか否か
                pro.StartInfo.RedirectStandardOutput = true;                     // 標準出力をリダイレクトして取得したい

                pro.Start();

                //プロセス終了まで待機する
                //WaitForExitはReadToEndの後である必要がある
                //(親プロセス、子プロセスでブロック防止のため)
                pro.WaitForExit();
                pro.Close();

                Console.WriteLine("\n->\n" + baseName[0] + ".ccs\n");
                continue;
            }
            else if (baseName[baseName.Length - 1] != "vsqx")
            {
                Console.WriteLine(currentFileName + "\nNot vsqx.\nSkip\n");
                continue;
            }

            // TODO: vsqx判定処理
            if (baseName[baseName.Length - 1] != "vsqx")
            {
                //XMLSchemaCheck(vsqxXsd, currentFileName);
                Console.WriteLine(currentFileName + "\nBroken vsqx.\nSkip\n");
                continue;
            }
            */

            // すでにファイルがある場合の処理
            /*
            int i = 0;
            while (!System.IO.File.Exists(baseName[0] + ".ccs"))
            {
                baseName[0] = baseName[0] + " (" + i + ")";
                i++;
            }
            */

            saveFileName = baseName[0] + ".ccs";

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;                                // インデントあり
            settings.Encoding = Encoding.UTF8;

            XmlWriter writer = null;
            XmlReader reader = null;
            NoteData note = new NoteData();


            try
            {
                reader = XmlReader.Create(new StreamReader(vsqxFile));

                while (reader.Read())   // ノードを一つずつ読む
                {
                    if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "vsUnit")
                    {
                        while (reader.Read())//vsUnit
                        {
                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "vsTrackNo")
                            {
                                // トラック作成
                                trackArray.Add(new TrackData());
                                trackArray[trackArray.Count - 1].SetTrackNum(reader.ReadElementString());
                            }

                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "mute")
                            {
                                trackArray[trackArray.Count - 1].SetMute(int.Parse(reader.ReadElementString()));
                            }

                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "solo")
                            {
                                trackArray[trackArray.Count - 1].SetSolo(int.Parse(reader.ReadElementString()));
                                break;
                            }
                        }
                    }// トラック if end


                    // 拍子取得
                    if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.LocalName == "timeSig")
                    {
                        while (reader.Read())//tempo
                        {
                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "posMes")
                            {
                                beatArray.Add(new BeatData());
                                beatArray[beatArray.Count - 1].SetPosMes(int.Parse(reader.ReadElementString()));
                            }
                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "nume")
                            {
                                beatArray[beatArray.Count - 1].SetNume(reader.ReadElementString());
                            }
                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "denomi")
                            {
                                beatArray[beatArray.Count - 1].SetDenomi(reader.ReadElementString());
                                break;
                            }
                        }//while timeSig end
                    }//if timeSig end


                    // テンポ取得
                    if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.LocalName == "tempo")
                    {
                        while (reader.Read())//tempo
                        {
                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.LocalName == "posTick")
                            {
                                bpmArray.Add(new BpmData());
                                bpmArray[bpmArray.Count - 1].SetClock(reader.ReadElementString());
                            }

                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.LocalName == "bpm")
                            {
                                bpmArray[bpmArray.Count - 1].SetTempo(reader.ReadElementString());

                                // テンポが8000/12000といった風に長さが違う場合の処理,V3上でのテンポは20~300なのでxsd判定すればOK
                                if (bpmArray[bpmArray.Count - 1].GetTempo().Length > 4)
                                {
                                    bpmArray[bpmArray.Count - 1].SetIntegerPoint(bpmArray[bpmArray.Count - 1].GetTempo().Substring(0, 3));
                                    bpmArray[bpmArray.Count - 1].SetDecimalPoint(bpmArray[bpmArray.Count - 1].GetTempo().Substring(3));
                                }
                                else
                                {
                                    bpmArray[bpmArray.Count - 1].SetIntegerPoint(bpmArray[bpmArray.Count - 1].GetTempo().Substring(0, 2));
                                    bpmArray[bpmArray.Count - 1].SetDecimalPoint(bpmArray[bpmArray.Count - 1].GetTempo().Substring(2));
                                }
                                break;
                            }
                        }//while temp end
                    }//if temp end



                    // トラックに含まれるノート作成
                    if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.LocalName == "vsTrack")
                    {
                        int TrackNo = 0;
                        while (reader.Read())//vsTrack
                        {

                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "vsTrackNo")
                            {
                                noteArray[TrackNo] = new List<NoteData>();
                                trackArray[TrackNo].SetTrackNum(reader.ReadElementString());
                            }

                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "trackName")
                            {
                                trackArray[TrackNo].SetTrackName(reader.ReadElementString());
                            }

                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "musicalPart")
                            {
                                while (reader.Read())
                                {
                                    if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "note")
                                    {
                                        while (reader.Read())
                                        {
                                            // 開始地点
                                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "posTick")
                                            {
                                                // ノートごとのクラスの作成
                                                noteArray[TrackNo].Add(new NoteData());
                                                noteArray[TrackNo][noteArray[TrackNo].Count - 1].SetBeginTick(reader.ReadElementString());
                                            }

                                            // 開始地点
                                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "playTime")
                                            {
                                                // ノートごとのクラスの作成
                                                noteArray[TrackNo][noteArray[TrackNo].Count - 1].SetPlayTime(reader.ReadElementString());
                                            }

                                            // デュレーション
                                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "durTick")
                                            {
                                                noteArray[TrackNo][noteArray[TrackNo].Count - 1].SetDuration(reader.ReadElementString());
                                            }

                                            // ノートナンバー
                                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "noteNum")
                                            {
                                                noteArray[TrackNo][noteArray[TrackNo].Count - 1].SetNoteNum(int.Parse(reader.ReadElementString()));
                                            }

                                            // 歌詞
                                            if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name == "lyric")
                                            {
                                                noteArray[TrackNo][noteArray[TrackNo].Count - 1].SetNoteLyric(reader.ReadElementString());
                                                break;
                                            }
                                        }
                                    }//if note end

                                    if (reader.NodeType == System.Xml.XmlNodeType.EndElement && reader.Name == "musicalPart")
                                    {
                                        trackArray[TrackNo].SetNote(noteArray[TrackNo]);
                                        TrackNo++;
                                        break;
                                    }

                                }//while musicalPart end

                            }//if musicalPart end

                        }//if vsTrackNo end

                    }// ノートif end

                }// 一番上のwhile end

            }
            finally
            {
                // XMLリーダーを終了
                if (reader != null) reader.Close();
            }



            try
            {
                writer = XmlWriter.Create(saveFileName, settings);

                writer.WriteStartDocument();                                               // XMLドキュメント開始
                writer.WriteStartElement("Scenario");                                      // Scenario要素開始
                writer.WriteAttributeString("Code", deff.GetCode());   // 属性

                writer.WriteStartElement("Sequence");                    // Sequence要素開始
                writer.WriteAttributeString("Id", "");                   // Id属性

                writer.WriteStartElement("Scene");                       // Sequence要素開始
                writer.WriteAttributeString("Id", "");                   // Id属性

                writer.WriteStartElement("Units");                       // Units要素開始


                // ノート書き込み
                foreach (TrackData currentTrack in trackArray)
                {
                    writer.WriteStartElement("Unit");                                   // Unit要素開始
                    writer.WriteAttributeString("Version", "1.0");                      // Version属性
                    writer.WriteAttributeString("Id", "");                              // Id属性
                    writer.WriteAttributeString("Category", "SingerSong");              // Category属性
                    writer.WriteAttributeString("Group", currentTrack.GetTrackGuid());  // Group属性
                    writer.WriteAttributeString("StartTime", "00:00:00");               // StartTime属性
                    writer.WriteAttributeString("Duration", "10:00:00");                // Duration属性

                    writer.WriteStartElement("Song");                                   // Song要素開始
                    writer.WriteAttributeString("Version", "1.02");                     // Version属性


                    if (bpmArray != null)
                    {
                        writer.WriteStartElement("Tempo");                                      // Tempo要素開始
                        foreach (BpmData currentBpm in bpmArray)
                        {
                            writer.WriteStartElement("Sound");                                      // Sound要素開始
                            writer.WriteAttributeString("Clock", currentBpm.GetClock());            // Clock属性
                            writer.WriteAttributeString("Tempo", currentBpm.GetIntegerPoint());     // Tempo属性
                            writer.WriteEndElement();                                               // Sound終了
                        }
                        writer.WriteEndElement();                                               // Tempo終了
                    }

                    if (beatArray != null)
                    {
                        writer.WriteStartElement("Beat");                                                               // Beat要素開始
                        foreach (BeatData currentBeat in beatArray)
                        {
                            writer.WriteStartElement("Time");                                                               // Time要素開始
                            writer.WriteAttributeString("Clock", currentBeat.GetPosMes().ToString());    // Clock属性
                            writer.WriteAttributeString("Beats", currentBeat.GetNume());                  // Beats属性
                            writer.WriteAttributeString("BeatType", currentBeat.GetDenomi());            // BeatType属性
                            writer.WriteEndElement();                                                                       // Time終了
                        }
                        writer.WriteEndElement();                                                                       // Beat終了
                    }

                    writer.WriteStartElement("Score");                                                  // Score要素開始
                    writer.WriteStartElement("Key");                                                    // Key要素開始
                    writer.WriteAttributeString("Clock", "0");                                          // Clock属性
                    writer.WriteAttributeString("Fifths", "0");                                         // Fifths属性
                    writer.WriteAttributeString("Mode", "0");                                           // Mode属性
                    writer.WriteEndElement();                                                           // Key終了


                    if (currentTrack.GetNote() != null)
                    {
                        foreach (NoteData currentNote in currentTrack.GetNote())
                        {
                            writer.WriteStartElement("Note");                                           // Note要素開始
                            writer.WriteAttributeString("Clock", currentNote.GetClock());               // Clock属性
                            writer.WriteAttributeString("PitchStep", currentNote.GetPitchStep());       // PitchStep属性
                            writer.WriteAttributeString("PitchOctave", currentNote.GetPitchOctave());   // PitchOctave属性
                            writer.WriteAttributeString("Duration", currentNote.GetDuration());         // Duration属性
                            writer.WriteAttributeString("Lyric", currentNote.GetLyric());               // Lyric属性
                            writer.WriteEndElement();                                                   // Note要素終了
                        }
                    }

                    writer.WriteEndElement();               // Score終了
                    writer.WriteEndElement();               // Song終了
                    writer.WriteEndElement();               // Unit終了
                }

                writer.WriteEndElement();               // Units終了


                writer.WriteStartElement("Groups");                                            // Groups要素開始

                /*
                writer.WriteStartElement("Group");                                             // Group要素開始
                writer.WriteAttributeString("Version", "1.0");                                 // Version属性
                writer.WriteAttributeString("Id", "2da68d23-4a9a-4f57-9e32-c0190f2d80ee");     // Tempo属性
                writer.WriteAttributeString("Category", "TextVocal");                          // Category属性
                writer.WriteAttributeString("Name", "トーク 1");                               // Name属性
                writer.WriteAttributeString("Color", "#FF1E90FF");                             // Color属性
                writer.WriteAttributeString("Volume", "0");                                    // Volume属性
                writer.WriteAttributeString("Pan", "0");                                       // Pan属性
                writer.WriteAttributeString("IsSolo", "false");                                // IsSolo属性
                writer.WriteAttributeString("IsMuted", "false");                               // IsMuted属性
                writer.WriteEndElement();                                                      // Group終了
                */

                // ノート書き込み
                if (trackArray != null)
                {
                    foreach (TrackData currentTrack in trackArray)
                    {
                        writer.WriteStartElement("Group");                                  // Group要素開始
                        writer.WriteAttributeString("Version", "1.0");                      // Version属性
                        writer.WriteAttributeString("Id", currentTrack.GetTrackGuid());     // Tempo属性
                        writer.WriteAttributeString("Category", "SingerSong");              // Category属性
                        writer.WriteAttributeString("Name", currentTrack.GetTrackName());   // Name属性
                        writer.WriteAttributeString("Color", "#FFFF0000");                  // Color属性
                        writer.WriteAttributeString("Volume", "0");                         // Volume属性
                        writer.WriteAttributeString("Pan", "0");                            // Pan属性
                        writer.WriteAttributeString("IsSolo", currentTrack.GetSolo().ToString());            // IsSolo属性
                        writer.WriteAttributeString("IsMuted", currentTrack.GetMute().ToString());           // IsMuted属性
                        writer.WriteEndElement();                                           // Group終了   
                    }
                }

                writer.WriteEndElement();                               // Groups終了

                writer.WriteStartElement("SoundSetting");               // SoundSetting要素開始
                writer.WriteAttributeString("Rhythm", "4/4");           // Rhythm属性
                writer.WriteAttributeString("Tempo", "78");             // Tempo属性
                writer.WriteEndElement();                               // SoundSetting終了

                writer.WriteEndElement();               // Scene終了
                writer.WriteEndElement();               // Sequence終了
                writer.WriteEndElement();               // Scenario終了

                writer.WriteEndDocument();              // XMLドキュメント終了
            }
            catch (Exception e)
            {
                MessageBox.Show("Save Error", e.ToString());
            }
            finally
            {
                // Console.WriteLine("" + currentFileName + "\n->\n" + saveFileName + "\n");
                // ファイルを閉じる
                if (writer != null) writer.Close();
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private int count = 0;

        private void addVSQXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "Vocaloid3 Sequence (*.vsqx)|*.vsqx|All files (*.*)|*.*";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] row = { openFileDialog1.SafeFileName, "V3", openFileDialog1.FileName };
                var listViewItem = new ListViewItem(row);
                lvVSQX.Items.Add(listViewItem);
            }
        }

        private void lvVSQs_DoubleClick(object sender, EventArgs e)
        {
            // 더블 클릭시 아이템 삭제
            // when an item double-clicked, the item is deleted.
            Console.WriteLine();
            if(lvVSQX.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selection Error", "Please select only one item.");
            }
            else
            {
                lvVSQX.Items.Remove(lvVSQX.SelectedItems[0]);
            }
            
        }

        private List<String> GetVsqxPathsFromListView()
        {
            var paths = new List<String>();

            foreach(ListViewItem item in lvVSQX.Items)
            {
                paths.Add(item.SubItems[2].Text);
            }

            return paths;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<String> vsqxFiles = GetVsqxPathsFromListView();
            if (vsqxFiles.Count == 0)
            {
                MessageBox.Show("Empty LIst", "Please add at least an item");
                return;
            }


            pbConvert.Value = 0;
            pbConvert.Maximum = vsqxFiles.Count;
            pbConvert.Step = 1;

            foreach (String vsqxFile in vsqxFiles)
            {
                if (!ConvertVsqxToCcs(vsqxFile))
                {
                    logging($"{vsqxFile} is Failed!");
                }
                pbConvert.PerformStep();
            }

            MessageBox.Show("Success!", "All FIle is completed successfully!");
        }
    }
}
