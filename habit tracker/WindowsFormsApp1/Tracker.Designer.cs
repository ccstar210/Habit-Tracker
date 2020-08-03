




namespace WindowsFormsApp1
{
    partial class Tracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbMood = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.cbWater = new System.Windows.Forms.ComboBox();
            this.gbMood = new System.Windows.Forms.GroupBox();
            this.gbWater = new System.Windows.Forms.GroupBox();
            this.gbSleep = new System.Windows.Forms.GroupBox();
            this.TimePickerSleep = new System.Windows.Forms.DateTimePicker();
            this.gbWake = new System.Windows.Forms.GroupBox();
            this.TimePickerWake = new System.Windows.Forms.DateTimePicker();
            this.gbMoney = new System.Windows.Forms.GroupBox();
            this.cbExercise = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbWorkout = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbDate = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbMeals = new System.Windows.Forms.GroupBox();
            this.richTxtDinner = new System.Windows.Forms.RichTextBox();
            this.richTxtLunch = new System.Windows.Forms.RichTextBox();
            this.richTxtBreakfast = new System.Windows.Forms.RichTextBox();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.gbNotes = new System.Windows.Forms.GroupBox();
            this.richTxtNotes = new System.Windows.Forms.RichTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.gbMood.SuspendLayout();
            this.gbWater.SuspendLayout();
            this.gbSleep.SuspendLayout();
            this.gbWake.SuspendLayout();
            this.gbMoney.SuspendLayout();
            this.gbWorkout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbMeals.SuspendLayout();
            this.gbNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Overall Mood";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Water Intake";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wake Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sleep Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Money Spent";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(1378, 759);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 48);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbMood
            // 
            this.cbMood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMood.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMood.FormattingEnabled = true;
            this.cbMood.Items.AddRange(new object[] {
            "Bad",
            "Average",
            "Good",
            "Fabulous"});
            this.cbMood.Location = new System.Drawing.Point(16, 58);
            this.cbMood.Name = "cbMood";
            this.cbMood.Size = new System.Drawing.Size(246, 33);
            this.cbMood.TabIndex = 1;
            this.cbMood.SelectedIndexChanged += new System.EventHandler(this.cbMood_SelectedIndexChanged);
            this.cbMood.TextChanged += new System.EventHandler(this.cbMood_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(472, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 38);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Habit Tracker!";
            // 
            // txtMoney
            // 
            this.txtMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMoney.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(14, 51);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(246, 32);
            this.txtMoney.TabIndex = 0;
            // 
            // cbWater
            // 
            this.cbWater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWater.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWater.Items.AddRange(new object[] {
            "< 4 fl oz.",
            "4 fl oz.",
            "8 fl oz.",
            "12 fl oz.",
            "16 fl oz.",
            "> 16 fl oz."});
            this.cbWater.Location = new System.Drawing.Point(11, 54);
            this.cbWater.Name = "cbWater";
            this.cbWater.Size = new System.Drawing.Size(256, 33);
            this.cbWater.TabIndex = 0;
            this.cbWater.SelectedIndexChanged += new System.EventHandler(this.cbWater_SelectedIndexChanged);
            this.cbWater.TextChanged += new System.EventHandler(this.cbWater_TextChanged);
            // 
            // gbMood
            // 
            this.gbMood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMood.Controls.Add(this.label3);
            this.gbMood.Controls.Add(this.cbMood);
            this.gbMood.Location = new System.Drawing.Point(907, 59);
            this.gbMood.Name = "gbMood";
            this.gbMood.Size = new System.Drawing.Size(281, 110);
            this.gbMood.TabIndex = 1;
            this.gbMood.TabStop = false;
            // 
            // gbWater
            // 
            this.gbWater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWater.Controls.Add(this.label4);
            this.gbWater.Controls.Add(this.cbWater);
            this.gbWater.Location = new System.Drawing.Point(1226, 59);
            this.gbWater.Name = "gbWater";
            this.gbWater.Size = new System.Drawing.Size(311, 110);
            this.gbWater.TabIndex = 2;
            this.gbWater.TabStop = false;
            // 
            // gbSleep
            // 
            this.gbSleep.Controls.Add(this.TimePickerSleep);
            this.gbSleep.Controls.Add(this.label6);
            this.gbSleep.Location = new System.Drawing.Point(305, 200);
            this.gbSleep.Name = "gbSleep";
            this.gbSleep.Size = new System.Drawing.Size(311, 119);
            this.gbSleep.TabIndex = 4;
            this.gbSleep.TabStop = false;
            // 
            // TimePickerSleep
            // 
            this.TimePickerSleep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePickerSleep.CustomFormat = "hh:mm";
            this.TimePickerSleep.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePickerSleep.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerSleep.Location = new System.Drawing.Point(11, 55);
            this.TimePickerSleep.Name = "TimePickerSleep";
            this.TimePickerSleep.ShowUpDown = true;
            this.TimePickerSleep.Size = new System.Drawing.Size(274, 32);
            this.TimePickerSleep.TabIndex = 17;
            // 
            // gbWake
            // 
            this.gbWake.Controls.Add(this.TimePickerWake);
            this.gbWake.Controls.Add(this.label5);
            this.gbWake.Location = new System.Drawing.Point(43, 197);
            this.gbWake.Name = "gbWake";
            this.gbWake.Size = new System.Drawing.Size(247, 122);
            this.gbWake.TabIndex = 3;
            this.gbWake.TabStop = false;
            // 
            // TimePickerWake
            // 
            this.TimePickerWake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimePickerWake.CustomFormat = "hh:mm";
            this.TimePickerWake.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePickerWake.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerWake.Location = new System.Drawing.Point(17, 58);
            this.TimePickerWake.Name = "TimePickerWake";
            this.TimePickerWake.ShowUpDown = true;
            this.TimePickerWake.Size = new System.Drawing.Size(201, 32);
            this.TimePickerWake.TabIndex = 17;
            this.TimePickerWake.Value = new System.DateTime(2020, 5, 24, 0, 0, 0, 0);
            // 
            // gbMoney
            // 
            this.gbMoney.Controls.Add(this.label7);
            this.gbMoney.Controls.Add(this.txtMoney);
            this.gbMoney.Location = new System.Drawing.Point(633, 200);
            this.gbMoney.Name = "gbMoney";
            this.gbMoney.Size = new System.Drawing.Size(283, 119);
            this.gbMoney.TabIndex = 5;
            this.gbMoney.TabStop = false;
            // 
            // cbExercise
            // 
            this.cbExercise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExercise.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExercise.FormattingEnabled = true;
            this.cbExercise.Items.AddRange(new object[] {
            "None",
            "Walking",
            "Workout",
            "Running"});
            this.cbExercise.Location = new System.Drawing.Point(23, 54);
            this.cbExercise.Name = "cbExercise";
            this.cbExercise.Size = new System.Drawing.Size(518, 33);
            this.cbExercise.TabIndex = 0;
            this.cbExercise.SelectedIndexChanged += new System.EventHandler(this.cbExercise_SelectedIndexChanged);
            this.cbExercise.TextChanged += new System.EventHandler(this.cbExercise_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Exercise";
            // 
            // gbWorkout
            // 
            this.gbWorkout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWorkout.Controls.Add(this.label1);
            this.gbWorkout.Controls.Add(this.cbExercise);
            this.gbWorkout.Location = new System.Drawing.Point(941, 197);
            this.gbWorkout.Name = "gbWorkout";
            this.gbWorkout.Size = new System.Drawing.Size(611, 122);
            this.gbWorkout.TabIndex = 6;
            this.gbWorkout.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 774);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 221);
            this.dataGridView1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(753, 32);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // gbDate
            // 
            this.gbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDate.Controls.Add(this.label2);
            this.gbDate.Controls.Add(this.dateTimePicker1);
            this.gbDate.Location = new System.Drawing.Point(43, 59);
            this.gbDate.Name = "gbDate";
            this.gbDate.Size = new System.Drawing.Size(809, 110);
            this.gbDate.TabIndex = 0;
            this.gbDate.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Today\'s Date";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.gbMeals);
            this.panel1.Controls.Add(this.gbNotes);
            this.panel1.Controls.Add(this.gbMood);
            this.panel1.Controls.Add(this.gbWake);
            this.panel1.Controls.Add(this.gbSleep);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.gbMoney);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.gbWorkout);
            this.panel1.Controls.Add(this.gbWater);
            this.panel1.Controls.Add(this.gbDate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1591, 1014);
            this.panel1.TabIndex = 17;
            // 
            // gbMeals
            // 
            this.gbMeals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMeals.Controls.Add(this.richTxtDinner);
            this.gbMeals.Controls.Add(this.richTxtLunch);
            this.gbMeals.Controls.Add(this.richTxtBreakfast);
            this.gbMeals.Controls.Add(this.lblDinner);
            this.gbMeals.Controls.Add(this.lblLunch);
            this.gbMeals.Controls.Add(this.lblBreakfast);
            this.gbMeals.Location = new System.Drawing.Point(43, 337);
            this.gbMeals.Name = "gbMeals";
            this.gbMeals.Size = new System.Drawing.Size(1494, 215);
            this.gbMeals.TabIndex = 7;
            this.gbMeals.TabStop = false;
            // 
            // richTxtDinner
            // 
            this.richTxtDinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtDinner.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtDinner.Location = new System.Drawing.Point(1004, 62);
            this.richTxtDinner.Name = "richTxtDinner";
            this.richTxtDinner.Size = new System.Drawing.Size(464, 133);
            this.richTxtDinner.TabIndex = 5;
            this.richTxtDinner.Text = "";
            // 
            // richTxtLunch
            // 
            this.richTxtLunch.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtLunch.Location = new System.Drawing.Point(520, 62);
            this.richTxtLunch.Name = "richTxtLunch";
            this.richTxtLunch.Size = new System.Drawing.Size(424, 133);
            this.richTxtLunch.TabIndex = 4;
            this.richTxtLunch.Text = "";
            // 
            // richTxtBreakfast
            // 
            this.richTxtBreakfast.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBreakfast.Location = new System.Drawing.Point(30, 62);
            this.richTxtBreakfast.Name = "richTxtBreakfast";
            this.richTxtBreakfast.Size = new System.Drawing.Size(444, 133);
            this.richTxtBreakfast.TabIndex = 3;
            this.richTxtBreakfast.Text = "";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinner.Location = new System.Drawing.Point(1009, 22);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(92, 29);
            this.lblDinner.TabIndex = 1;
            this.lblDinner.Text = "Dinner";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunch.Location = new System.Drawing.Point(534, 22);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(84, 29);
            this.lblLunch.TabIndex = 0;
            this.lblLunch.Text = "Lunch";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakfast.Location = new System.Drawing.Point(21, 22);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(125, 29);
            this.lblBreakfast.TabIndex = 0;
            this.lblBreakfast.Text = "Breakfast";
            // 
            // gbNotes
            // 
            this.gbNotes.Controls.Add(this.richTxtNotes);
            this.gbNotes.Controls.Add(this.lblNotes);
            this.gbNotes.Location = new System.Drawing.Point(43, 560);
            this.gbNotes.Name = "gbNotes";
            this.gbNotes.Size = new System.Drawing.Size(944, 180);
            this.gbNotes.TabIndex = 8;
            this.gbNotes.TabStop = false;
            // 
            // richTxtNotes
            // 
            this.richTxtNotes.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtNotes.Location = new System.Drawing.Point(17, 46);
            this.richTxtNotes.Name = "richTxtNotes";
            this.richTxtNotes.Size = new System.Drawing.Size(901, 107);
            this.richTxtNotes.TabIndex = 20;
            this.richTxtNotes.Text = "";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(8, 10);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(82, 29);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes";
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 1014);
            this.Controls.Add(this.panel1);
            this.Name = "Tracker";
            this.Text = "Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tracker_FormClosing);
            this.Load += new System.EventHandler(this.Tracker_Load);
            this.gbMood.ResumeLayout(false);
            this.gbMood.PerformLayout();
            this.gbWater.ResumeLayout(false);
            this.gbWater.PerformLayout();
            this.gbSleep.ResumeLayout(false);
            this.gbSleep.PerformLayout();
            this.gbWake.ResumeLayout(false);
            this.gbWake.PerformLayout();
            this.gbMoney.ResumeLayout(false);
            this.gbMoney.PerformLayout();
            this.gbWorkout.ResumeLayout(false);
            this.gbWorkout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDate.ResumeLayout(false);
            this.gbDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMeals.ResumeLayout(false);
            this.gbMeals.PerformLayout();
            this.gbNotes.ResumeLayout(false);
            this.gbNotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbMood;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.ComboBox cbWater;
        private System.Windows.Forms.GroupBox gbMood;
        private System.Windows.Forms.GroupBox gbWater;
        private System.Windows.Forms.GroupBox gbSleep;
        private System.Windows.Forms.GroupBox gbWake;
        private System.Windows.Forms.GroupBox gbMoney;
        private System.Windows.Forms.ComboBox cbExercise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbWorkout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TimePickerWake;
        private System.Windows.Forms.DateTimePicker TimePickerSleep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbNotes;
        private System.Windows.Forms.RichTextBox richTxtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.GroupBox gbMeals;
        private System.Windows.Forms.RichTextBox richTxtDinner;
        private System.Windows.Forms.RichTextBox richTxtLunch;
        private System.Windows.Forms.RichTextBox richTxtBreakfast;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblBreakfast;
    }
}

