using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormLincor
{
    public class MultiLevelDock
    {
        List<Dock<ILincor>> dockStages;
        public const int countPlaces = 20;
        private int pictureHeight;
        private int pictureWidth;
        public MultiLevelDock(int countStages, int pictureWidth, int pictureHeight)
        {
            dockStages = new List<Dock<ILincor>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                dockStages.Add(new Dock<ILincor>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        public Dock<ILincor> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < dockStages.Count)
                {
                    return dockStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                sw.WriteLine("CountLeveles:" + dockStages.Count);
                foreach (var level in dockStages)
                {
                    sw.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var lin = level[i];
                        if (lin != null)
                        {
                            if (lin.GetType().Name == "Lincor")
                            {
                                sw.Write(i + ":Lincor:");
                            }
                            if (lin.GetType().Name == "WarShip")
                            {
                                sw.Write(i + ":WarShip:");
                            }
                            sw.WriteLine(lin);
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            int counter = -1;
            ILincor lin = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string str = sr.ReadLine();
                if (str.Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(str.Split(':')[1]);
                    if (dockStages != null)
                    {
                        dockStages.Clear();
                    }
                    dockStages = new List<Dock<ILincor>>(count);
                }
                else
                {
                    return false;
                }
                while ((str = sr.ReadLine()) != null)
                {
                    if (str == "Level")
                    {
                        counter++;
                        dockStages.Add(new Dock<ILincor>(countPlaces,
                        pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(str))
                    {
                        continue;
                    }
                    string[] splitStr = str.Split(':');
                    if (splitStr.Length > 2)
                    {
                        if (splitStr[1] == "Lincor")
                        {
                            lin = new Lincor(splitStr[2]);
                        }
                        else if (splitStr[1] == "WarShip")
                        {
                            lin = new WarShip(splitStr[2]);
                        }
                        dockStages[counter][Convert.ToInt32(splitStr[0])] = lin;
                    }
                }
                return true;
            }
        }
        public bool SaveLevelData(string filename, int selectedLevel)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (selectedLevel < 0 || selectedLevel >= dockStages.Count)
            {
                return false;
            }
            if (dockStages[selectedLevel] == null)
            {
                return false;
            }
            var level = dockStages[selectedLevel];
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < countPlaces; i++)
                {
                    var lin = level[i];
                    if (lin != null)
                    {
                        if (lin.GetType().Name == "Lincor")
                        {
                            sw.WriteLine(i + ":ArmorCar:" + lin);
                        }
                        if (lin.GetType().Name == "WarShip")
                        {
                            sw.WriteLine(i + ":WarShip+`:" + lin);
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadLevelData(string filename, int selectedLevel)
        {
            if (selectedLevel < 0 || selectedLevel >= dockStages.Count)
            {
                return false;
            }
            if (!File.Exists(filename) || dockStages[selectedLevel] == null)
            {
                return false;
            }
            dockStages[selectedLevel].Clear();
            ILincor lin = null;
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    string[] splitLine = line.Split(':');
                    if (splitLine.Length > 2)
                    {
                        if (splitLine[1] == "ArmorCar")
                        {
                            lin = new Lincor(splitLine[2]);
                        }
                        else
                        {
                            lin = new WarShip(splitLine[2]);
                        }
                        if (lin != null)
                        {
                            dockStages[selectedLevel][Convert.ToInt32(splitLine[0])] = lin;
                        }
                    }
                }
                return true;
            }
        }
    }
}
