using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Tracker : Form
    {
        //FileHandler object to deal with reading/writing/saving the excel file
        FileHandler file = new FileHandler();

        //name of excel file to send data to
        string excelFileName = "habit_tracker.xlsx";

        List<Entry> entryList; 
        

        public Tracker()
        {
            InitializeComponent();
        }


        private void Tracker_Load(object sender, EventArgs e)
        {
            expandScreen();

            //initialize the date to today's date and can't set a future date
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today;

            //initialize money spent to 0
            txtMoney.Text = "$0";

            //get the list of entries from the excel file
            entryList = file.readFile(excelFileName);

            //display all the entries from the excel file in the datagridview
            dataGridView1.DataSource = DisplayData(entryList);

        }

        //When user clicks the "Add" button, an entry object is created and added to the excel file. The entry is displayed in the datagridview
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Create an entry object based on data entered to add to file
            Entry entry = new Entry(dateTimePicker1.Value.ToShortDateString(), cbMood.Text, cbWater.Text, TimePickerWake.Value.ToShortTimeString(),
                                    TimePickerSleep.Value.ToShortTimeString(), txtMoney.Text, cbExercise.Text,
                                    richTxtBreakfast.Text, richTxtLunch.Text, richTxtDinner.Text, richTxtNotes.Text);



            //Print entry data to the datagridview
            AddData(entry, dataGridView1);           

            file.writeToFile(entry, excelFileName);

           

        }

        //isFilled() method returns true if the textboxes are not empty, else it returns false
        //used to determine if "add" button can be enabled, Notes, breakfast, lunch, and dinner fields can be left empty
        private bool isFilled()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(cbMood.Text))
                result = false;
            if (string.IsNullOrWhiteSpace(cbWater.Text))
                result = false;
            if (string.IsNullOrWhiteSpace(cbExercise.Text))
                result = false;

            return result;

        }

        //enableAdd() method enables the "add" button when all the applicable fields are filled via isFilled() method
        private void enableAdd()
        {
            if (isFilled())
                btnAdd.Enabled = true;
        }

        //only enable the add button when all fields are entered
        private void cbMood_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void cbMood_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }
        private void cbWater_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void cbWater_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void cbExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void cbExercise_TextChanged(object sender, EventArgs e)
        {
            enableAdd();
        }


        //AddData() takes an entry object, sets the columns titles, and displays each member variable in the gridview
        public void AddData(Entry entry, DataGridView dgv)
        {
            System.Data.DataTable dataTable = (System.Data.DataTable)dgv.DataSource;
            DataRow row = dataTable.NewRow();
            row[0] = entry.Date;
            row[1] = entry.Mood;
            row[2] = entry.Water;
            row[3] = entry.Wake;
            row[4] = entry.Sleep;
            row[5] = entry.Money;
            row[6] = entry.Exercise;
            row[7] = entry.Breakfast;
            row[8] = entry.Lunch;
            row[9] = entry.Dinner;
            row[10] = entry.Notes;
            dataTable.Rows.Add(row);
            dataTable.AcceptChanges();

        }

        //DisplayData() takes a list of the entry objects from the excel file, sets the columns titles, 
        // and displays each member variable in the gridview
        public System.Data.DataTable DisplayData( List<Entry> list)
        {
            //update gridview
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Mood", typeof(string));
            table.Columns.Add("Water Intake", typeof(string));
            table.Columns.Add("Wake Time", typeof(string));
            table.Columns.Add("Sleep Time", typeof(string));
            table.Columns.Add("Money Spent", typeof(string));
            table.Columns.Add("Exercise", typeof(string));
            table.Columns.Add("Breakfast", typeof(string));
            table.Columns.Add("Lunch", typeof(string));
            table.Columns.Add("Dinner", typeof(string));
            table.Columns.Add("Notes", typeof(string));

            foreach(Entry entry in list)
            {
                table.Rows.Add(entry.Date, entry.Mood, entry.Water, entry.Wake, entry.Sleep, entry.Money, entry.Exercise, entry.Breakfast,
                           entry.Lunch, entry.Dinner, entry.Notes);
            }
            

            return table;
        }

        //Expand the program to full screen
        private void expandScreen()
        {
            int iHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Height += iHeight;
            int iWidth = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Width += iWidth;
            this.CenterToScreen();
        }

        
    }
}
