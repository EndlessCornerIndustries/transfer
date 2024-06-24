using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer.Models
{
    public interface IPerson
    {

    }

    public class Person : IPerson
    {
        private DateTime _calendar;
        private DateTime _birthDate;
        private List<Education> _educations;
        private string _stage {  get; set; }
        private List<Illness> illnesses;

        //private int infectionSusceptibility;

        public Person(DateTime calendar)
        {
            _calendar = calendar;
            _birthDate = _calendar;
        }

        public void Update()
        {
            var currentLife = _calendar.Subtract(_birthDate);
        }

        public void UpdateIllness()
        {

        }

        public void AddEducation()
        {

        }
        /*
        public void IncreaseAge()
        {
            _ageYears += 1;
        }

        public int GetAge()
        {
            return _ageYears;
        }*/
    }

    public class Illness
    {
        public string type { get; set; }
        public int durationInDays { get; set; }
    }

    public class Education
    {

    }
}
