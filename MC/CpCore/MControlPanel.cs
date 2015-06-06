using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;

namespace CpCore
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MControlPanel
    {

        public Control Host { get; set; }

        [JsonProperty]
        public List<MControl> MCs = new List<MControl>();

        [JsonProperty]
        public bool ShowBorder = true;

        [JsonProperty]
        public bool Drageble = true;

        public void Reload(bool filereload = false)
        {
            Host.Controls.Clear();

            foreach (MControl i in MCs)
            {
                Host.Controls.Add(i);
                new TCResize(i);
                if (filereload)
                {
                    i.mod.Hcontrol = i;
                    i.mod.Engine.Host = i;
                }
                i.mod.Start();
                if (ShowBorder)
                {
                    i.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    i.BorderStyle = BorderStyle.None;
                }

                DragExtension.Draggable(i, Drageble);


                //i.Controls.Clear();

            }

        }

        public MControlPanel()
        {

        }

        public void AddNewPanel(MControl p)
        {
            MCs.Add(p);
            Reload();
        }

        public MControlPanel(Panel col)
        {
            Host = col;
        }

        public static MControlPanel Load(string file)
        {
            return JsonConvert.DeserializeObject<MControlPanel>(File.ReadAllText(file));
        }

        public static void Save(string file, MControlPanel instance)
        {
            File.WriteAllText(file, JsonConvert.SerializeObject(instance));
        }

        public void ShowBorders(bool p)
        {

            ShowBorder = p;
            Reload();
        }

        public void CanDrag(bool p)
        {
            Drageble = p;
            Reload();
        }
    }
}
