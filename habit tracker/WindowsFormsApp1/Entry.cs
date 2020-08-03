
/* *********************************************************************************************************************************
 * Entry class to represent each row in the excel file. 
 * Includes 11 fields: date, mood, water, wake, sleep, money, exercise, breakfast, lunch, dinner, and notes 
 ***********************************************************************************************************************************/

namespace WindowsFormsApp1
{
    public class Entry
    {
        private string date;
        private string mood;
        private string water;
        private string wake;
        private string sleep;
        private string money;
        private string exercise;
        private string breakfast;
        private string lunch;
        private string dinner;
        private string notes;

        public string Date { get => date; set => date = value; }
        public string Mood { get => mood; set => mood = value; }
        public string Water { get => water; set => water = value; }
        public string Wake { get => wake; set => wake = value; }
        public string Sleep { get => sleep; set => sleep = value; }
        public string Money { get => money; set => money = value; }
        public string Exercise { get => exercise; set => exercise = value; }
        public string Breakfast { get => breakfast; set => breakfast = value; }
        public string Lunch { get => lunch; set => lunch = value; }
        public string Dinner { get => dinner; set => dinner = value; }
        public string Notes { get => notes; set => notes = value; }

        public Entry(string date, string mood, string water, string wake, string sleep, string money, string exercise,
                     string breakfast, string lunch, string dinner, string notes)
        {
            Date = date;
            Mood = mood;
            Water = water;
            Wake = wake;
            Sleep = sleep;
            Money = money;
            Exercise = exercise;
            Breakfast = breakfast;
            Lunch = lunch;
            Dinner = dinner;
            Notes = notes;
        }
    }
}
