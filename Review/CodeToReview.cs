using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingAssessment.Review
{
    public class People
    {
        /* readonly variable should be initialise inside the constructor */
        private const DateTimeOffset Under16 = DateTimeOffset.UtcNow.AddYears(-15);
        public string Name { get; private set; }
        public DateTimeOffset DOB { get; private set; }

        public People(string name) : this(name, Under16.Date)
        {
        }

        public People(string name, DateTime dob)
        {
            Name = name;
            DOB = dob;
        }
    }

    public class BirthingUnit
    {
        /// <summary>
        /// MaxItemsToRetrieve
        /// </summary>
        private List<People> _people;

        public BirthingUnit()
        {
            _people = new List<People>();
        }

        /// <summary>
        /// GetPeoples
        /// </summary>
        /// <param name="j"></param>
        /// <returns>List<object></returns>
        public List<People> GetPeople(int i)
        {
            /*Rendom should initiale once*/
            var random = new Random();
            for (int j = 0; j < i; j++)
            {
                try
                {
                    // Creates a dandon Name
                    string name = string.Empty;

                    /* Next(0,1) return 0 allway so MaxValue should be 2 */
                    if (random.Next(2) == 0)
                    {
                        name = "Bob";
                    }
                    else {
                        name = "Betty";
                    }
                    // Adds new people to the list
                    _people.Add(new People(name, DateTime.UtcNow.Subtract(new TimeSpan(random.Next(18, 85) * 356, 0, 0, 0))));
                }
                catch (Exception e)
                {
                    // Dont think this should ever happen
                    throw new Exception("Something failed in user creation");
                }
            }
            return _people;
        }
        /*simplify the function and get BOB older then 30
          * DateTime.Now.Subtract does not give accurate result so use AddYears 
          */
        private IEnumerable<People> GetBobs(bool olderThan30)
        {
            var query = _people.Where(x => x.Name == "Bob");
            if (olderThan30)/* DateTime.Now.Subtract do not provide accurate result*/
                query.Where(x => x.DOB >= DateTime.Now.AddYears(-30));

            return query.AsEnumerable<People>();
        }

        public string GetMarried(People p, string lastName)
        {
            if (lastName.Contains("test"))
                return p.Name;
            if ((p.Name.Length + lastName).Length > 255)
            {
                (p.Name + " " + lastName).Substring(0, 255);
            }

            return p.Name + " " + lastName;
        }
    }
}