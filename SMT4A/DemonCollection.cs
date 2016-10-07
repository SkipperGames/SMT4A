using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;

namespace SMT4A
{
    class DemonCollection
    {

        public static List<Demon> Demons = new List<Demon>();

        public static void InitializeFromCSV()
        {
            try
            {
                using (FileStream fs = File.OpenRead(
                Application.StartupPath + "/demons.csv"))
                {
                    using (TextFieldParser parser = new TextFieldParser(fs))
                    {
                        parser.Delimiters = new string[1]
                        {
                            ","
                        };

                        parser.ReadLine();
                        while (!parser.EndOfData)
                        {
                            string[] line = parser.ReadFields();

                            if (!string.IsNullOrEmpty(line[2]) && line[3] != "n")
                            {
                                Demons.Add(new Demon()
                                {
                                    Id = (short)(parser.LineNumber - 1),
                                    Race = line[1],
                                    Name = line[2],
                                    HasSprite = true,
                                });
                            }
                            else continue;

                            if (parser.LineNumber >= short.MaxValue)
                            {
                                return;
                            }
                        }
                    }
                }
            }
            catch
            {
                throw new Exception("Demon CSV file doesn't exist");
            }
        }

        public static void SaveToJsonFile()
        {
            if (Demons.Count > 0)
            {
                try
                {
                    File.WriteAllText(
                        Application.StartupPath + "/demons.json",
                        JsonConvert.SerializeObject(Demons, Formatting.Indented));
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void SaveToTextFile()
        {
            if (Demons.Count > 0)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(
                    File.OpenWrite(
                        Application.StartupPath + "/demons.txt")))
                    {
                        for (int i = 0; i < Demons.Count; i++)
                        {
                            byte[] id_bytes = BitConverter.GetBytes(Demons[i].Id).Reverse().ToArray();
                            string id = BitConverter.ToString(id_bytes).Replace("-", "");

                            sw.WriteLine(
                                id + 
                                " = [" + Demons[i].Race + "] " +
                                Demons[i].Name);
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
    }
}