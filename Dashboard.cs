/**
 * Date: April 9, 2023
 * Course: DBAS5206-05
 * Group 5:
 * Stevenson Suhardy (Room Utilization Dashboard, AddEditRoom, AddEditRoomType)
 * Megh Patel (Physician-Patient Dashboard)
 * Harsh Patel (Assisted Physician-Patient Dashboard)
 * Jason Lyn (Assisted Room Utilization Dashboard)
 * 
 * IMPORTANT
 * Run the SQL Script
 * To make this application work, the connectionString needs to be changed from "STEVENSON" to whatever the SQL server name, the professor or anyone else have in the laptop.
 * 
 * Right-click project -> Properties -> Resources -> Change connectionString Data Source from STEVENSON to SQL Server name that is installed in the laptop / computer.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRCH_Hospital
{
    public partial class Dashboard : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();
            listBoxPatient.SelectedIndexChanged += MyListBox_SelectedIndexChanged;
            // Removes all dashboard tab pages except login
            tabControl1.TabPages.Remove(tabPageLogout);
            tabControl1.TabPages.Remove(tabPageRoom);
            tabControl1.TabPages.Remove(tabPagePhysicianPatient);
        }
        #endregion

        #region Helper Functions
        /// <summary>
        /// This function will return the connection string needed to connect to database
        /// </summary>
        /// <returns></returns>
        private string ReturnDatabaseConnection()
        {
            return Properties.Resources.connectionString;
        }

        /// <summary>
        /// This function is used to reset the list views in the room utilization dashboard
        /// </summary>
        private void ResetListViews()
        {
            listViewDischargingPatient.Items.Clear();
            listViewOccupancyByRooms.Items.Clear();
            listViewOccupancyByRoomType.Items.Clear();
        }

        /// <summary>
        /// This function is used to populate the list views in the room utilization dashboard.
        /// </summary>
        /// <param name="conn"></param>
        private void PopulateRoomDashboardLists(SqlConnection conn)
        {

            #region Populating the First List View
            string sqlQuery = "EXEC Num_Of_NonOrAvailable_Bed_Each_Room 1;";
            List<string> numOfEmptyBeds = new List<string>();
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        numOfEmptyBeds.Add(reader.GetString(0));
                        numOfEmptyBeds.Add(reader.GetInt32(1).ToString());
                    }
                }
            }
            sqlQuery = "EXEC Bed_IDs_NonOrAvailable_Each_Room 1;";
            List<string> emptyBeds = new List<string>();
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (emptyBeds.Contains(reader.GetString(0)))
                        {
                            int index = emptyBeds.IndexOf(reader.GetString(0));
                            string stringConcat = emptyBeds[index + 1] + ", " + reader.GetInt32(1).ToString();
                            emptyBeds.RemoveAt(index + 1);
                            emptyBeds.Insert(index + 1, stringConcat);
                        }
                        else
                        {
                            emptyBeds.Add(reader.GetString(0));
                            emptyBeds.Add(reader.GetInt32(1).ToString());
                        }
                    }
                }
            }
            sqlQuery = "SELECT * FROM View_Room_Details ORDER BY ROOM_LOCATION;";
            List<string> arr = new List<string>();
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 1;
                    while (reader.Read())
                    {
                        arr.Add(i.ToString());
                        arr.Add(reader.GetString(0));
                        arr.Add(reader.GetString(1));
                        arr.Add(reader.GetInt32(2).ToString());
                        if (reader.GetString(0).Equals(numOfEmptyBeds[0]))
                        {
                            arr.Add(numOfEmptyBeds[1]);
                            numOfEmptyBeds.Remove(numOfEmptyBeds[0]);
                            numOfEmptyBeds.Remove(numOfEmptyBeds[0]);
                        }
                        else
                        {
                            arr.Add("0");
                        }
                        if (reader.GetString(0).Equals(emptyBeds[0]))
                        {
                            arr.Add(emptyBeds[1]);
                            emptyBeds.Remove(emptyBeds[0]);
                            emptyBeds.Remove(emptyBeds[0]);
                            arr.Add("No");
                        }
                        else
                        {
                            arr.Add("");
                            arr.Add("Yes");
                        }
                        listViewOccupancyByRooms.Items.Add(new ListViewItem(arr.ToArray()));
                        arr.Clear();
                        i++;
                    }
                }
            }
            #endregion

            #region Populating the Second List View

            sqlQuery = "EXEC Num_Of_NonOrAvailable_Beds_Each_Room_Type 1";
            numOfEmptyBeds.Clear();
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        numOfEmptyBeds.Add(reader.GetString(0));
                        numOfEmptyBeds.Add(reader.GetInt32(1).ToString());
                    }
                }
            }

            sqlQuery = "EXEC Bed_IDs_NonOrAvailable_Each_Room_Type 1;";
            emptyBeds = new List<string>();
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (emptyBeds.Contains(reader.GetString(0)))
                        {
                            int index = emptyBeds.IndexOf(reader.GetString(0));
                            string stringConcat = emptyBeds[index + 1] + ", " + reader.GetInt32(1).ToString();
                            emptyBeds.RemoveAt(index + 1);
                            emptyBeds.Insert(index + 1, stringConcat);
                        }
                        else
                        {
                            emptyBeds.Add(reader.GetString(0));
                            emptyBeds.Add(reader.GetInt32(1).ToString());
                        }
                    }
                }
            }

            sqlQuery = "SELECT * FROM View_Room_Type_Details;";
            arr.Clear();
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int i = 1;
                    while (reader.Read())
                    {
                        arr.Add(i.ToString());
                        arr.Add(reader.GetString(0));
                        arr.Add(reader.GetInt32(1).ToString());
                        if (reader.GetString(0).Equals(numOfEmptyBeds[0]))
                        {
                            arr.Add(numOfEmptyBeds[1]);
                            numOfEmptyBeds.RemoveAt(0);
                            numOfEmptyBeds.RemoveAt(0);
                        }
                        else
                        {
                            arr.Add("0");
                        }
                        if (reader.GetString(0).Equals(emptyBeds[0]))
                        {
                            arr.Add(emptyBeds[1]);
                            emptyBeds.Remove(emptyBeds[0]);
                            emptyBeds.Remove(emptyBeds[0]);
                            arr.Add("No");
                        }
                        else
                        {
                            arr.Add("");
                            arr.Add("Yes");
                        }
                        listViewOccupancyByRoomType.Items.Add(new ListViewItem(arr.ToArray()));
                        arr.Clear();
                        i++;
                    }
                }
            }

            #endregion

            #region Populating the Third List View
            sqlQuery = "SELECT * FROM View_Discharging_Patients ORDER BY 'Patient ID'";
            arr.Clear();
            using (SqlCommand command = new SqlCommand(sqlQuery, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            arr.Add(reader.GetInt32(0).ToString());
                            arr.Add(reader.GetString(1));
                            arr.Add(reader.GetString(2));
                            arr.Add(reader.GetString(3));
                            arr.Add(reader.GetString(4));
                            arr.Add(reader.GetString(5));
                            arr.Add(reader.GetString(6));
                            listViewDischargingPatient.Items.Add(new ListViewItem(arr.ToArray()));
                            arr.Clear();
                        }
                    }
                }
            }
            #endregion
        }

        private void PopulateListBox()
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ReturnDatabaseConnection()))
            {

                string query = "select patient_fname, patient_lname from patient";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string firstName = reader.GetString(0);
                    string lastName = reader.GetString(1);

                    listBoxPatient.Items.Add(firstName + " " + lastName);

                }
                connection.Close();
            }
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// This event handler happens when user double clicks an item in the first list view is used when user wants to edit a room
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewOccupancyByRooms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // New Form
            using (AddEditRoom editRoom = new AddEditRoom())
            {
                // Show the delete button
                editRoom.SetRoomLocation(listViewOccupancyByRooms.SelectedItems[0].SubItems[1].Text);
                string oldLocation = editRoom.GetRoomLocation();
                string sqlQuery = "SELECT * FROM ROOM_TYPE;";
                using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                if (listViewOccupancyByRooms.SelectedItems[0].SubItems[2].Text.Equals(reader.GetString(1)))
                                {
                                    editRoom.SetRoomTypeID(reader.GetInt32(0));
                                    break;
                                }
                            }
                        }
                    }
                }
                if (editRoom.ShowDialog() == DialogResult.OK)
                {
                    sqlQuery = "EXEC Update_Room '" + oldLocation + "', '" + editRoom.GetRoomLocation() + "', " + editRoom.GetRoomTypeID().ToString() + ";";
                    using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
                    {
                        conn.Open();
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                        {
                            int row = command.ExecuteNonQuery();
                            if (row == 1)
                            {
                                MessageBox.Show("Room " + oldLocation + " has been updated.", "Sucess!");
                                ResetListViews();
                                PopulateRoomDashboardLists(conn);
                            }
                            else
                            {
                                MessageBox.Show("An error has occured.", "ERROR");
                            }
                        }
                    }
                }
            }
        }

        // event to generate data dynamicaly inside the text boxes
        private void MyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedName = listBoxPatient.SelectedIndex + 1;

            //string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(ReturnDatabaseConnection()))
            {
                string query = "SELECT patient.patient_id, patient.patient_fname, patient.patient_lname, patient.sex, TREATMENT.NOTES " +
                           "FROM patient " +
                           "LEFT JOIN APPOINTMENT ON patient.patient_id = APPOINTMENT.patient_id " +
                           "LEFT JOIN TREATMENT ON TREATMENT.TREATMENT_ID = APPOINTMENT.APPOINTMENT_id " +
                           "WHERE patient.patient_id = @patient_id";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@patient_id", selectedName);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string sex = reader.GetString(3);
                    string des = "";
                    if (!reader.IsDBNull(4))
                    {
                        des = reader.GetString(4);
                    }

                    textBoxID.Text = id.ToString();
                    textBoxFirstName.Text = firstName;
                    textBoxLastName.Text = lastName;
                    textBoxGender.Text = sex;
                    textBoxTreatment.Text = des;

                }


            }
        }

        /// <summary>
        /// This event handler will log out the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {

            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Insert(0, tabPageLogin);
        }

        /// <summary>
        /// This event handler will open another form and when user clicks ok on the form, it will add a new room in the database table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            using (AddEditRoom addRoom = new AddEditRoom())
            {
                if (addRoom.ShowDialog() == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
                    {
                        // Open the connection
                        conn.Open();

                        string sqlQuery = "EXEC Add_New_Room '" + addRoom.GetRoomLocation() + "', " + addRoom.GetRoomTypeID().ToString();
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows == 1)
                            {
                                MessageBox.Show("Room " + addRoom.GetRoomLocation() + " has successfully been added.", "Sucess!");

                                ResetListViews();
                                PopulateRoomDashboardLists(conn);
                            }
                            else
                            {
                                MessageBox.Show("An error has happened", "ERROR");
                            }
                        }

                    }
                }
            }
        }

        /// <summary>
        /// This event handler will happen when the form loads. It will query from the database and fill in the list views in each dashboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            #region Room Utilization Dashboard

            // This three regions will set the properties for each listviews
            #region First ListView Properties
            // Set the first list view properties
            listViewOccupancyByRooms.View = View.Details;
            listViewOccupancyByRooms.FullRowSelect = true;
            listViewOccupancyByRooms.GridLines = true;
            // Add columns to list view
            listViewOccupancyByRooms.Columns.Add("No.", 50, HorizontalAlignment.Left);
            listViewOccupancyByRooms.Columns.Add("Room Location", 90, HorizontalAlignment.Left);
            listViewOccupancyByRooms.Columns.Add("Room Type", 90, HorizontalAlignment.Left);
            listViewOccupancyByRooms.Columns.Add("Total Number of Beds", 125, HorizontalAlignment.Left);
            listViewOccupancyByRooms.Columns.Add("Number Of Empty Beds", 125, HorizontalAlignment.Left);
            listViewOccupancyByRooms.Columns.Add("Empty Bed Id(s)", 100, HorizontalAlignment.Left);
            listViewOccupancyByRooms.Columns.Add("Is Full?", 100, HorizontalAlignment.Left);
            #endregion

            #region Second ListView Properties
            // Set the second list view properties
            listViewOccupancyByRoomType.View = View.Details;
            listViewOccupancyByRoomType.FullRowSelect = true;
            listViewOccupancyByRoomType.GridLines = true;
            // Add columns to list view
            listViewOccupancyByRoomType.Columns.Add("No.", 50, HorizontalAlignment.Left);
            listViewOccupancyByRoomType.Columns.Add("Room Type", 90, HorizontalAlignment.Left);
            listViewOccupancyByRoomType.Columns.Add("Total Number of Beds", 125, HorizontalAlignment.Left);
            listViewOccupancyByRoomType.Columns.Add("Number Of Empty Beds", 125, HorizontalAlignment.Left);
            listViewOccupancyByRoomType.Columns.Add("Empty Bed Id(s)", 100, HorizontalAlignment.Left);
            listViewOccupancyByRoomType.Columns.Add("Is Full?", 100, HorizontalAlignment.Left);
            #endregion

            #region Third ListView Properties
            listViewDischargingPatient.View = View.Details;
            listViewDischargingPatient.FullRowSelect = true;
            listViewDischargingPatient.GridLines = true;
            // Add columns to list view
            listViewDischargingPatient.Columns.Add("Patient ID", 100, HorizontalAlignment.Left);
            listViewDischargingPatient.Columns.Add("Full Name", 125, HorizontalAlignment.Left);
            listViewDischargingPatient.Columns.Add("Address", 125, HorizontalAlignment.Left);
            listViewDischargingPatient.Columns.Add("City, Province, Postal Code", 125, HorizontalAlignment.Left);
            listViewDischargingPatient.Columns.Add("Phone Number", 100, HorizontalAlignment.Left);
            listViewDischargingPatient.Columns.Add("Gender", 100, HorizontalAlignment.Left);
            listViewDischargingPatient.Columns.Add("Extension", 100, HorizontalAlignment.Left);

            #endregion

            #region Database Queries
            // Create the connection
            using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
            {
                conn.Open();
                PopulateRoomDashboardLists(conn);
            }
            #endregion
            #endregion

            #region Physician-Patient Dashboard
            PopulateListBox();
            #endregion
        }

        /// <summary>
        /// This event handler will check whether or not the user has entered the correct credentials and allow access if correct if not, then show error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
            {
                conn.Open();

                string sqlQuery = "EXEC Find_User '" + textBoxUsername.Text + "', '" + textBoxPassword.Text + "';";

                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    if (command.ExecuteScalar() != null)
                    {
                        tabControl1.TabPages.Remove(tabPageLogin);
                        tabControl1.TabPages.Add(tabPageLogout);
                        tabControl1.TabPages.Add(tabPageRoom);
                        tabControl1.TabPages.Add(tabPagePhysicianPatient);
                        textBoxPassword.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// This event handler will show a form to add a new room type to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRoomType_Click(object sender, EventArgs e)
        {
            using (AddEditRoomType addRoomType = new AddEditRoomType())
            {
                if (addRoomType.ShowDialog() == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
                    {
                        // Open the connection
                        conn.Open();

                        string sqlQuery = "EXEC Add_Room_Type '" + addRoomType.GetRoomType() + "';";
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows == 1)
                            {
                                MessageBox.Show("Room Type " + addRoomType.GetRoomType() + " has successfully been added.", "Sucess!");

                                ResetListViews();
                                PopulateRoomDashboardLists(conn);
                            }
                            else
                            {
                                MessageBox.Show("An error has happened", "ERROR");
                            }
                        }

                    }
                }
            }
        }

        /// <summary>
        /// This event handler will open up another form filled with the clicked room in the list view. The user is able to update the room details if needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewOccupancyByRoomType_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (AddEditRoomType editRoomType = new AddEditRoomType())
            {
                editRoomType.SetRoomType(listViewOccupancyByRoomType.SelectedItems[0].SubItems[1].Text);
                string oldRoomType = editRoomType.GetRoomType();

                if (editRoomType.ShowDialog() == DialogResult.OK)
                {
                    string sqlQuery = "EXEC Update_Room_Type '" + oldRoomType + "', '" + editRoomType.GetRoomType() + "';";
                    using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
                    {
                        conn.Open();
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                        {
                            int row = command.ExecuteNonQuery();
                            if (row == 1)
                            {
                                MessageBox.Show("Room Type " + oldRoomType + " has been updated.", "Sucess!");
                                ResetListViews();
                                PopulateRoomDashboardLists(conn);
                            }
                            else
                            {
                                MessageBox.Show("An error has occured.", "ERROR");
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
