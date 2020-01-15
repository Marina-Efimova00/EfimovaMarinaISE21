using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    public class MultiLevelDock
    {
        List<Dock<ILincor>> dockStages;
        private const int countPlaces = 20;
        public MultiLevelDock(int countStages, int pictureWidth, int pictureHeight)
        {
            dockStages = new List<Dock<ILincor>>();
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
        public ILincor this[int level, int key]
        {
            get
            {
                if (level > -1 && level < dockStages.Count)
                {
                    return dockStages[level].GetTransportByKey(key);
                }
                return null;
            }
        }
    }
}
