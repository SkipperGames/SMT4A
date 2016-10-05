using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace SMT4A
{
    class SkillCollection
    {
        public static List<Skill> Skills = new List<Skill>();

        public static void InitializeFromJson()
        {
            try
            {
                Skills = JsonConvert.DeserializeObject<List<Skill>>(
                    File.ReadAllText(
                        Application.StartupPath + "/skills.json"));
            }
            catch
            {
                throw new Exception("Skill JSON file doesn't exist");
            }
        }

        public static void SaveToJsonFile()
        {
            if (Skills.Count > 0)
            {
                try
                {
                    File.WriteAllText(
                        Application.StartupPath + "/skills.json",
                        JsonConvert.SerializeObject(Skills, Formatting.Indented));
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void SaveToTextFile()
        {
            if (Skills.Count > 0)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(
                    File.OpenWrite(
                        Application.StartupPath + "/skills.txt")))
                    {
                        for (int i = 0; i < Skills.Count; i++)
                        {
                            byte[] id_bytes = BitConverter.GetBytes(Skills[i].Id).Reverse().ToArray();
                            string id = BitConverter.ToString(id_bytes).Replace("-", "");

                            sw.WriteLine(id + " = " + Skills[i].Name);
                        }
                    }
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}