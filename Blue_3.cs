using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_6;
public class Blue_3
{
    public struct Participant 
    {
        private string _name;
        private string _surname;
        private int[] _penaltyTimes;

        public string Name => _name;
        public string Surname => _surname;
        public int[] PenaltyTimes
        {
            get
            {
                if (_penaltyTimes == null) 
                    return default(int[]);
                int[] newPenaltyTimes = new int[_penaltyTimes.Length];
                for (int i = 0; i<_penaltyTimes.Length; i++)
                    newPenaltyTimes[i] = _penaltyTimes[i];
                return newPenaltyTimes;
            }
        }
        public int TotalTime
        {
            get
            {
                if (_penaltyTimes == null) 
                    return 0;
                int total = 0;
                foreach (int time in _penaltyTimes)
                    total+=time;
                return total;
            }
        }
        public bool IsExpelled
        {
            get 
            {
                if (_penaltyTimes == null || _penaltyTimes.Length == 0) 
                    return true;
                foreach (int time in _penaltyTimes)
                {
                    if (time == 10)
                        return false;
                }
                return true;
            }
        }

        public Participant(string name, string surName)
        {
            _name = name;
            _surname = surName;
            _penaltyTimes = new int[0];
        }

        public void PlayMatch(int time)
        {
            if (_penaltyTimes == null) 
                return;
            int[] newpenaltyTimes = new int[_penaltyTimes.Length+1];
            Array.Copy(_penaltyTimes, newpenaltyTimes, _penaltyTimes.Length);
            newpenaltyTimes[_penaltyTimes.Length] = time;
            _penaltyTimes = newpenaltyTimes;
        }

        public static void Sort(Participant[] array)
        {
            if (array == null || array.Length == 0) return;
            var sortedArray = array.OrderBy(partic => partic.TotalTime).ToArray();
            Array.Copy(sortedArray,array,array.Length);
        }

        public void Print()
        {
            WriteLine($"{_name} {_surname}: ");
            foreach (int time in _penaltyTimes)
                Write($"{time} ");
            WriteLine("");
            WriteLine($"Total time: {TotalTime} - {this.IsExpelled}");
        }
    }
}