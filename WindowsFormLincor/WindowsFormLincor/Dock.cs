using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLincor
{
    public class Dock<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Dock<T>>
        where T : class, ILincor
    {
        private Dictionary<int, T> _places;
        private int _maxCount;
        private int PictureWidth { get; set; }
        private const int _placeSizeWidth = 210;
        private int PictureHeight { get; set; }
        private const int _placeSizeHeight = 80;
        private int _currentIndex;
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }
        public Dock(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            _currentIndex = -1;
        }
        public static int operator +(Dock<T> p, T lin)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new DockOverflowException();
            }
            if (p._places.ContainsValue(lin))
            {
                throw new DockAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, lin);
                    p._places[i].SetPosition(5 + i / 5 * _placeSizeWidth + 5,
                     i % 5 * _placeSizeHeight + 15, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Dock<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T lin = p._places[index];
                p._places.Remove(index);
                return lin;
            }
            throw new DockNotFoundException(index);
        }
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            foreach (var lin in _places)
            {
                lin.Value.DrawLincor(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                return null;
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5
                    * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new DockOccupiedPlaceException(ind);
                }
            }
        }
        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {
            _places.Clear();
        }
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(Dock<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is WarShip && other._places[thisKeys[i]] is
                   Lincor)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is Lincor && other._places[thisKeys[i]]
                    is WarShip)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is WarShip && other._places[thisKeys[i]] is
                    WarShip)
                    {
                        return (_places[thisKeys[i]] is
                       WarShip).CompareTo(other._places[thisKeys[i]] is WarShip);
                    }
                    if (_places[thisKeys[i]] is Lincor && other._places[thisKeys[i]]
                    is Lincor)
                    {
                        return (_places[thisKeys[i]] is
                       Lincor).CompareTo(other._places[thisKeys[i]] is Lincor);
                    }
                }
            }
            return 0;
        }
    }
}
