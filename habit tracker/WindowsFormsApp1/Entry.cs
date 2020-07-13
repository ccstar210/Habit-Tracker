using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Entry
    {
        private string date;
        private string exercise;
        private string water;
        private string mood;
        private string wake;
        private string sleep;
        private string money;
        private string breakfast;
        private string lunch;
        private string dinner;
        private string notes;

        public string Date { get => date; set => date = value; }
        public string Exercise { get => exercise; set => exercise = value; }
        public string Water { get => water; set => water = value; }
        public string Mood { get => mood; set => mood = value; }
        public string Wake { get => wake; set => wake = value; }
        public string Sleep { get => sleep; set => sleep = value; }
        public string Money { get => money; set => money = value; }
        public string Breakfast { get => breakfast; set => breakfast = value; }
        public string Lunch { get => lunch; set => lunch = value; }
        public string Dinner { get => dinner; set => dinner = value; }
        public string Notes { get => notes; set => notes = value; }

        public Entry(string date, string exercise, string water, string mood, string wake, string sleep, string money,
                     string breakfast, string lunch, string dinner, string notes)
        {
            Date = date;
            Exercise = exercise;
            Water = water;
            Mood = mood;
            Wake = wake;
            Sleep = sleep;
            Money = money;
            Breakfast = breakfast;
            Lunch = lunch;
            Dinner = dinner;
            Notes = notes;
        }
    }
}
