using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    internal class People
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string age;
        public string Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }

        private string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        private string position;
        public string Position
        {
            get { return position; }
            set
            {
                position = value;
                OnPropertyChanged();
            }
        }

        private string date;
        public string Date
        {
            get { return Date; }
            set
            {
                Date = value;
                OnPropertyChanged();
            }
        }

        public People()
        {
            Id = 0;
        }

        public People(string name, string age, string city, string position, string hobby)
        {
            Name = name;
            Age = age;
            City = city;
            Position = position;
            Date = date;
        }

        public People(string sor)
        {
            string[] t = sor.Split(',');
            Name = t[0];
            Age = t[1];
            City = t[2];
            Position = t[3];
            Date = t[4];
        }

        public override string? ToString()
        {
            return $"{Name}, {Age}, {City}, {Position}, {Date}.";
        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
