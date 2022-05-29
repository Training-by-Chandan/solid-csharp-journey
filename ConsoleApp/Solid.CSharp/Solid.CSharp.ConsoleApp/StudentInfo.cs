namespace Solid.DSharp
{
    public class StudentInfo
    {
        public StudentInfo()
        {
            _age = 10;
        }

        public StudentInfo(string name)
        {
            _name = name;
        }

        public StudentInfo(double min, double max, double pass)
        {
            _min = min;
            _max = max;
            _pass = pass;
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //public int Age { get; set; }

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 100)
                {
                    _age = 100;
                }
                else if (value < 5)
                {
                    _age = 5;
                }
                else
                {
                    _age = value;
                }
            }
        }

        private double _min = 0;
        private double _max = 100;
        private double _pass = 32;

        public double Min
        { get { return _min; } }

        public double Max => _max;
        public double Pass => _pass;

        private double _math;

        public double Math
        {
            get
            {
                return _math;
            }
            set
            {
                if (value > _max)
                {
                    _math = _max;
                }
                else if (value < _min)
                {
                    _math = _min;
                }
                else
                {
                    _math = value;
                }
            }
        }

        private double _english;

        public double English
        {
            get
            {
                return _english;
            }
            set
            {
                _english = (value > _max) ? _max : (value < _min) ? _min : value;
            }
        }

        private double _science;

        public double Science
        {
            get
            {
                return _science;
            }
            set
            {
                if (value > _max)
                {
                    _science = _max;
                }
                else if (value < _min)
                {
                    _science = _min;
                }
                else
                {
                    _science = value;
                }
            }
        }

        private double _computer;

        public double Computer
        {
            get
            {
                return _computer;
            }
            set
            {
                if (value > _max)
                {
                    _computer = _max;
                }
                else if (value < _min)
                {
                    _computer = _min;
                }
                else
                {
                    _computer = value;
                }
            }
        }

        public double Total
        {
            get { return Math + Science + Computer; }
        }

        public double Percentage
        {
            get
            {
                return Total / (3 * _max) * 100;
            }
        }

        public string Division
        {
            get
            {
                var div = "";
                if (Percentage >= 80) div = "Distinction";
                else if (Percentage >= 60) div = "First Division";
                else if (Percentage >= 45) div = "Second Division";
                else if (Percentage >= 32) div = "Third Division";
                else div = "Failed";

                return div;
            }
        }

        public StudentInfo GetNewObject()
        {
            return new StudentInfo();
        }

        public static StudentInfo operator +(StudentInfo first
            , StudentInfo second)
        {
            var totalMin = first.Min + second.Min;
            var totalMax = first.Max + second.Max;
            var totalPass = first.Pass + second.Pass;
            StudentInfo total = new StudentInfo(totalMin, totalMax, totalPass);
            total.Math = first.Math + second.Math;
            total.Science = first.Science + second.Science;
            total.English = first.English + second.English;
            return total;
        }

        public static StudentInfo operator -(StudentInfo first
            , StudentInfo second)
        {
            var totalMin = first.Min + second.Min;
            var totalMax = first.Max + second.Max;
            var totalPass = first.Pass + second.Pass;
            StudentInfo total = new StudentInfo(totalMin, totalMax, totalPass);
            total.Math = first.Math - second.Math;
            total.Science = first.Science - second.Science;
            total.English = first.English - second.English;
            return total;
        }

        public static StudentInfo operator ++(StudentInfo first)
        {
            first.Math++;
            first.Science++;
            first.English++;
            return first;
        }

        public static StudentInfo operator +(StudentInfo first, int num)
        {
            first.Math += 5;
            first.Science += 5;
            first.English += 5;
            return first;
        }

        public static bool operator ==(StudentInfo obj1, StudentInfo obj2)
        {
            return obj1.Math == obj2.Math && obj1.Science == obj2.Science && obj1.English == obj2.English;
        }

        public static bool operator !=(StudentInfo obj1, StudentInfo obj2)
        {
            return !(obj1.Math == obj2.Math && obj1.Science == obj2.Science && obj1.English == obj2.English);
        }
    }
}