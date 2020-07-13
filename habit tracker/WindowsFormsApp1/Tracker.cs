using Microsoft.Office.Interop.Excel;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Tracker : Form
    {
        //FileHandler object to deal with reading/writing/saving the excel file
        FileHandler file = new FileHandler();
        //name of excel file to send data to
        string excelFileName = "tracker.xlsx";
        //string excelFileName = "test1.xlsx";
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


            // Construct an image object from a file in the local directory.
            Image image = Image.FromFile("road.JPG");
            // Set the PictureBox image property to this image.
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //set labels to transperent so can see the background image
            panel1.Parent = pictureBox1;
            panel1.BackColor = Color.Transparent;
            //gbMood.Parent = pictureBox1;
            gbMood.BackColor = Color.Transparent;
            //gbWater.Parent = pictureBox1;
            gbWater.BackColor = Color.Transparent;
            //gbDate.Parent = pictureBox1;
            gbDate.BackColor = Color.Transparent;
            //gbSleep.Parent = pictureBox1;
            gbSleep.BackColor = Color.Transparent;
            //gbWake.Parent = pictureBox1;
            gbWake.BackColor = Color.Transparent;
            //gbMoney.Parent = pictureBox1;
            gbMoney.BackColor = Color.Transparent;
            //gbWorkout.Parent = pictureBox1;
            gbWorkout.BackColor = Color.Transparent;
            //lblTitle.Parent = pictureBox1;
            lblTitle.BackColor = Color.Transparent;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Create an entry object based on data entered to add to file
            Entry entry = new Entry(dateTimePicker1.Value.ToShortDateString(), cbExercise.Text, cbWater.Text, cbMood.Text,
                                    TimePickerWake.Value.ToShortTimeString(), TimePickerSleep.Value.ToShortTimeString(), txtMoney.Text, 
                                    richTxtBreakfast.Text, richTxtLunch.Text, richTxtDinner.Text, richTxtNotes.Text);

            //Print entry data to the datagridview
            dataGridView1.DataSource = DisplayData(entry);

            file.writeToFile(entry, excelFileName);

            //disable add button, can only add one entry at a time
            btnAdd.Enabled = false;

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
        private void cbWater_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void cbMood_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAdd();
        }

        private void cbExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableAdd();
        }


        //DisplayData() takes an entry object, sets the columns titles, and displays each member variable in the gridview
        public System.Data.DataTable DisplayData(Entry entry)
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

            table.Rows.Add(entry.Date, entry.Mood, entry.Water, entry.Wake, entry.Sleep, entry.Money, entry.Exercise, entry.Breakfast,
                           entry.Lunch, entry.Dinner, entry.Notes); 

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
