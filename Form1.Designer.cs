namespace Project
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpLogin = new System.Windows.Forms.TabPage();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tpRegister = new System.Windows.Forms.TabPage();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnRegister2 = new System.Windows.Forms.Button();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tpBooking = new System.Windows.Forms.TabPage();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtArrivalTime = new System.Windows.Forms.TextBox();
            this.cboxTo = new System.Windows.Forms.ComboBox();
            this.cboxFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.dtpDateOfDep = new System.Windows.Forms.DateTimePicker();
            this.lblTimeOfArr = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.tpFlights = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpBucketlist = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.clboxBucketlist = new System.Windows.Forms.CheckedListBox();
            this.txtBucketlist = new System.Windows.Forms.TextBox();
            this.lblBucketlist = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpBooking.SuspendLayout();
            this.tpFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpBucketlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpLogin);
            this.tabControl1.Controls.Add(this.tpRegister);
            this.tabControl1.Controls.Add(this.tpBooking);
            this.tabControl1.Controls.Add(this.tpFlights);
            this.tabControl1.Controls.Add(this.tpBucketlist);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1153, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tpLogin
            // 
            this.tpLogin.Controls.Add(this.lblWelcome);
            this.tpLogin.Controls.Add(this.btnRegister);
            this.tpLogin.Controls.Add(this.btnLogin);
            this.tpLogin.Controls.Add(this.txtPassword);
            this.tpLogin.Controls.Add(this.txtEmail);
            this.tpLogin.Controls.Add(this.lblPassword);
            this.tpLogin.Controls.Add(this.pictureBox1);
            this.tpLogin.Controls.Add(this.lblEmail);
            this.tpLogin.Location = new System.Drawing.Point(4, 29);
            this.tpLogin.Name = "tpLogin";
            this.tpLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogin.Size = new System.Drawing.Size(1145, 415);
            this.tpLogin.TabIndex = 0;
            this.tpLogin.Text = "Login";
            this.tpLogin.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(417, 309);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 20);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome To Travelopedia Airlines!";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(544, 377);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 32);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(437, 377);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(793, 343);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(243, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 343);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(705, 346);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.airlines;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1142, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(75, 346);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // tpRegister
            // 
            this.tpRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpRegister.Controls.Add(this.numericUpDownAge);
            this.tpRegister.Controls.Add(this.lblAge);
            this.tpRegister.Controls.Add(this.txtNation);
            this.tpRegister.Controls.Add(this.txtPhone);
            this.tpRegister.Controls.Add(this.txtPassword2);
            this.tpRegister.Controls.Add(this.txtEmail2);
            this.tpRegister.Controls.Add(this.txtLastName);
            this.tpRegister.Controls.Add(this.txtFirstName);
            this.tpRegister.Controls.Add(this.btnRegister2);
            this.tpRegister.Controls.Add(this.lblNation);
            this.tpRegister.Controls.Add(this.lblPhone);
            this.tpRegister.Controls.Add(this.lblPassword2);
            this.tpRegister.Controls.Add(this.lblEmail2);
            this.tpRegister.Controls.Add(this.lblLastName);
            this.tpRegister.Controls.Add(this.lblFirstName);
            this.tpRegister.Controls.Add(this.pictureBox2);
            this.tpRegister.Location = new System.Drawing.Point(4, 29);
            this.tpRegister.Name = "tpRegister";
            this.tpRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegister.Size = new System.Drawing.Size(1145, 415);
            this.tpRegister.TabIndex = 1;
            this.tpRegister.Text = "Register";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(248, 329);
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(121, 26);
            this.numericUpDownAge.TabIndex = 15;
            this.numericUpDownAge.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(110, 335);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(42, 20);
            this.lblAge.TabIndex = 14;
            this.lblAge.Text = "Age:";
            // 
            // txtNation
            // 
            this.txtNation.Location = new System.Drawing.Point(248, 281);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(243, 26);
            this.txtNation.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(248, 227);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(243, 26);
            this.txtPhone.TabIndex = 12;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(248, 179);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(243, 26);
            this.txtPassword2.TabIndex = 11;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(248, 124);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(243, 26);
            this.txtEmail2.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(248, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(243, 26);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(248, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(243, 26);
            this.txtFirstName.TabIndex = 8;
            // 
            // btnRegister2
            // 
            this.btnRegister2.Location = new System.Drawing.Point(359, 370);
            this.btnRegister2.Name = "btnRegister2";
            this.btnRegister2.Size = new System.Drawing.Size(104, 32);
            this.btnRegister2.TabIndex = 7;
            this.btnRegister2.Text = "Register";
            this.btnRegister2.UseVisualStyleBackColor = true;
            this.btnRegister2.Click += new System.EventHandler(this.btnRegister2_Click);
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Location = new System.Drawing.Point(110, 287);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(86, 20);
            this.lblNation.TabIndex = 6;
            this.lblNation.Text = "Nationality:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(110, 233);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(119, 20);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(110, 182);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(82, 20);
            this.lblPassword2.TabIndex = 4;
            this.lblPassword2.Text = "Password:";
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(110, 127);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(52, 20);
            this.lblEmail2.TabIndex = 3;
            this.lblEmail2.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(110, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(110, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Project.Properties.Resources.travelopedia;
            this.pictureBox2.Location = new System.Drawing.Point(935, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tpBooking
            // 
            this.tpBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpBooking.Controls.Add(this.btnView);
            this.tpBooking.Controls.Add(this.btnBook);
            this.tpBooking.Controls.Add(this.txtArrivalTime);
            this.tpBooking.Controls.Add(this.cboxTo);
            this.tpBooking.Controls.Add(this.cboxFrom);
            this.tpBooking.Controls.Add(this.lblTo);
            this.tpBooking.Controls.Add(this.lblFrom);
            this.tpBooking.Controls.Add(this.txtArrivalDate);
            this.tpBooking.Controls.Add(this.dtpDateOfDep);
            this.tpBooking.Controls.Add(this.lblTimeOfArr);
            this.tpBooking.Controls.Add(this.lblArrival);
            this.tpBooking.Controls.Add(this.lblDeparture);
            this.tpBooking.Location = new System.Drawing.Point(4, 29);
            this.tpBooking.Name = "tpBooking";
            this.tpBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tpBooking.Size = new System.Drawing.Size(1145, 415);
            this.tpBooking.TabIndex = 2;
            this.tpBooking.Text = "Booking";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(578, 361);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(149, 37);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View Your Flights";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(422, 361);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(149, 37);
            this.btnBook.TabIndex = 12;
            this.btnBook.Text = "Book Flight";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(852, 261);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.ReadOnly = true;
            this.txtArrivalTime.Size = new System.Drawing.Size(108, 26);
            this.txtArrivalTime.TabIndex = 10;
            // 
            // cboxTo
            // 
            this.cboxTo.FormattingEnabled = true;
            this.cboxTo.Items.AddRange(new object[] {
            "Amman, Jordan",
            "Damascus, Syria",
            "Baghdad, Iraq",
            "Beirut, Lebanon",
            "Abu Dhabi, UAE",
            "Dubai, UAE",
            "Moscow, Russia",
            "Kirov, Russia",
            "Michigan, USA"});
            this.cboxTo.Location = new System.Drawing.Point(796, 85);
            this.cboxTo.Name = "cboxTo";
            this.cboxTo.Size = new System.Drawing.Size(214, 28);
            this.cboxTo.TabIndex = 9;
            // 
            // cboxFrom
            // 
            this.cboxFrom.FormattingEnabled = true;
            this.cboxFrom.Items.AddRange(new object[] {
            "Amman, Jordan",
            "Damascus, Syria",
            "Baghdad, Iraq",
            "Beirut, Lebanon",
            "Abu Dhabi, UAE",
            "Dubai, UAE",
            "Moscow, Russia",
            "Kirov, Russia",
            "Michigan, USA"});
            this.cboxFrom.Location = new System.Drawing.Point(114, 85);
            this.cboxFrom.Name = "cboxFrom";
            this.cboxFrom.Size = new System.Drawing.Size(213, 28);
            this.cboxFrom.TabIndex = 8;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(792, 62);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(31, 20);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(110, 62);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(50, 20);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From:";
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(114, 261);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.ReadOnly = true;
            this.txtArrivalDate.Size = new System.Drawing.Size(213, 26);
            this.txtArrivalDate.TabIndex = 5;
            // 
            // dtpDateOfDep
            // 
            this.dtpDateOfDep.CustomFormat = "";
            this.dtpDateOfDep.Location = new System.Drawing.Point(422, 189);
            this.dtpDateOfDep.Name = "dtpDateOfDep";
            this.dtpDateOfDep.Size = new System.Drawing.Size(305, 26);
            this.dtpDateOfDep.TabIndex = 4;
            this.dtpDateOfDep.ValueChanged += new System.EventHandler(this.dtpDateOfDep_ValueChanged);
            // 
            // lblTimeOfArr
            // 
            this.lblTimeOfArr.AutoSize = true;
            this.lblTimeOfArr.Location = new System.Drawing.Point(848, 238);
            this.lblTimeOfArr.Name = "lblTimeOfArr";
            this.lblTimeOfArr.Size = new System.Drawing.Size(112, 20);
            this.lblTimeOfArr.TabIndex = 3;
            this.lblTimeOfArr.Text = "Time of Arrival:";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(110, 238);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(56, 20);
            this.lblArrival.TabIndex = 1;
            this.lblArrival.Text = "Arrival:";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(463, 166);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(213, 20);
            this.lblDeparture.TabIndex = 0;
            this.lblDeparture.Text = "Date and TIme of Departure:";
            // 
            // tpFlights
            // 
            this.tpFlights.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpFlights.Controls.Add(this.dataGridView1);
            this.tpFlights.Location = new System.Drawing.Point(4, 29);
            this.tpFlights.Name = "tpFlights";
            this.tpFlights.Padding = new System.Windows.Forms.Padding(3);
            this.tpFlights.Size = new System.Drawing.Size(1145, 415);
            this.tpFlights.TabIndex = 3;
            this.tpFlights.Text = "Your Flights";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpBucketlist
            // 
            this.tpBucketlist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tpBucketlist.Controls.Add(this.btnAdd);
            this.tpBucketlist.Controls.Add(this.clboxBucketlist);
            this.tpBucketlist.Controls.Add(this.txtBucketlist);
            this.tpBucketlist.Controls.Add(this.lblBucketlist);
            this.tpBucketlist.Location = new System.Drawing.Point(4, 29);
            this.tpBucketlist.Name = "tpBucketlist";
            this.tpBucketlist.Padding = new System.Windows.Forms.Padding(3);
            this.tpBucketlist.Size = new System.Drawing.Size(1145, 415);
            this.tpBucketlist.TabIndex = 4;
            this.tpBucketlist.Text = "Bucketlist";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(230, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // clboxBucketlist
            // 
            this.clboxBucketlist.BackColor = System.Drawing.Color.AliceBlue;
            this.clboxBucketlist.FormattingEnabled = true;
            this.clboxBucketlist.Items.AddRange(new object[] {
            "Barcelona, Spain",
            "Santorini, Greece"});
            this.clboxBucketlist.Location = new System.Drawing.Point(610, 65);
            this.clboxBucketlist.Name = "clboxBucketlist";
            this.clboxBucketlist.Size = new System.Drawing.Size(354, 257);
            this.clboxBucketlist.TabIndex = 2;
            // 
            // txtBucketlist
            // 
            this.txtBucketlist.Location = new System.Drawing.Point(192, 175);
            this.txtBucketlist.Name = "txtBucketlist";
            this.txtBucketlist.Size = new System.Drawing.Size(164, 26);
            this.txtBucketlist.TabIndex = 1;
            // 
            // lblBucketlist
            // 
            this.lblBucketlist.AutoSize = true;
            this.lblBucketlist.Location = new System.Drawing.Point(173, 152);
            this.lblBucketlist.Name = "lblBucketlist";
            this.lblBucketlist.Size = new System.Drawing.Size(207, 20);
            this.lblBucketlist.TabIndex = 0;
            this.lblBucketlist.Text = "Add your dream destination:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Travelopedia Airlines";
            this.tabControl1.ResumeLayout(false);
            this.tpLogin.ResumeLayout(false);
            this.tpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpRegister.ResumeLayout(false);
            this.tpRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpBooking.ResumeLayout(false);
            this.tpBooking.PerformLayout();
            this.tpFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpBucketlist.ResumeLayout(false);
            this.tpBucketlist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpLogin;
        private System.Windows.Forms.TabPage tpRegister;
        private System.Windows.Forms.TabPage tpBooking;
        private System.Windows.Forms.TabPage tpFlights;
        private System.Windows.Forms.TabPage tpBucketlist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister2;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblTimeOfArr;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.DateTimePicker dtpDateOfDep;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtBucketlist;
        private System.Windows.Forms.Label lblBucketlist;
        private System.Windows.Forms.ComboBox cboxTo;
        private System.Windows.Forms.ComboBox cboxFrom;
        private System.Windows.Forms.CheckedListBox clboxBucketlist;
        private System.Windows.Forms.TextBox txtArrivalTime;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnView;
    }
}

