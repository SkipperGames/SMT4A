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

        public static void InitializeFromCSV()
        {
            try
            {
                using (FileStream fs = File.OpenRead(
                Application.StartupPath + "/skills.csv"))
                {
                    using (TextFieldParser parser = new TextFieldParser(fs))
                    {
                        parser.Delimiters = new string[1]
                        {
                            "*"
                        };
                        
                        while (!parser.EndOfData)
                        {
                            string[] line = parser.ReadFields();

                            if (!string.IsNullOrEmpty(line[0]))
                            {
                                Skills.Add(new Skill()
                                {
                                    Id = (short)(parser.LineNumber - 1),
                                    Name = line[0],
                                    AttacksLow = int.Parse(line[1]),
                                    AttacksHigh = int.Parse(line[2]),
                                    Power = (Power)Enum.Parse(typeof(Power), line[3]),
                                    Element = (Element)Enum.Parse(typeof(Element), line[4]),
                                    Class = (Class)Enum.Parse(typeof(Class), line[5]),
                                    Target = (Target)Enum.Parse(typeof(Target), line[6]),
                                    Effect = line[7],
                                    MP = int.Parse(line[8]),
                                });
                            }
                            else continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                        sw.Close();
                    }
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void SaveToCSV()
        {
            // Id, Name, AttacksLow, AttacksHigh, Power, Element, Class, Target, Effect, MP
            if (Skills.Count > 0)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(
                    File.OpenWrite(
                        Application.StartupPath + "/skills.csv")))
                    {
                        for (int i = 0; i < Skills.Count; i++)
                        {
                            Skill s = Skills[i];

                            string line =
                                s.Name + "*" +
                                s.AttacksLow + "*" +
                                s.AttacksHigh + "*" +
                                s.Power.ToString() + "*" +
                                s.Element.ToString() + "*" +
                                s.Class.ToString() + "*" +
                                s.Target.ToString() + "*" +
                                s.Effect + "*" +
                                s.MP + "*";

                            sw.WriteLine(line);
                        }
                        sw.WriteLine("*********");
                        sw.Close();
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