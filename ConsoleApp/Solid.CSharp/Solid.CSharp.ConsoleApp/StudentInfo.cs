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
        private double _pass = 40;

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
                    throw new Exception($"Number cannot be greater than {_max}");
                }
                else if (value < _min)
                {
                    throw new Exception($"Number cannot be less than {_min}");
                }
                else
                {
                    _math = value;
                }
            }
        }
    }
}