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
    public partial class AddEditRoom : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public AddEditRoom()
        {
            InitializeComponent();
            // Set display member and value member of the combo box
            comboBoxRoomType.DisplayMember = "Text";
            comboBoxRoomType.ValueMember = "ID";
            // Create the SqlConnection
            using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
            {
                // Open the connection
                conn.Open();

                // Query
                string sqlQuery = "SELECT * FROM ROOM_TYPE;";
                // Initialize list of combo items
                List<ComboItem> comboItem = new List<ComboItem>();
                // Create the SqlCommand
                using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                {
                    // Create the SqlDataReader and execute command
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Add to list of combo items for each room type
                        while (reader.Read())
                        {
                            comboItem.Add(new ComboItem { ID = reader.GetInt32(0), Text = reader.GetString(1) });
                        }
                    }
                }
                // Set the data source to the combo item list (converted to array)
                comboBoxRoomType.DataSource = comboItem.ToArray();
            }
        }
        #endregion

        #region Getters and Setters
        /// <summary>
        /// This function is used to set the room location textbox
        /// </summary>
        /// <param name="roomLocation"></param>
        public void SetRoomLocation(string roomLocation)
        {
            textBoxRoomLocation.Text = roomLocation;
        }

        /// <summary>
        /// This function is used to get the room location value
        /// </summary>
        /// <returns></returns>
        public string GetRoomLocation()
        {
            return textBoxRoomLocation.Text;
        }

        /// <summary>
        /// This function is used to set the room type id
        /// </summary>
        /// <param name="roomTypeID"></param>
        public void SetRoomTypeID(int roomTypeID)
        {
            comboBoxRoomType.SelectedValue = roomTypeID;
        }

        /// <summary>
        /// This function is used to get the room type id
        /// </summary>
        /// <returns></returns>
        public int GetRoomTypeID()
        {
            return (int)comboBoxRoomType.SelectedValue;
        }
        #endregion

        #region Helper Functions

        /// <summary>
        /// This function returns the database connection
        /// </summary>
        /// <returns></returns>
        private string ReturnDatabaseConnection()
        {
            return Properties.Resources.connectionString;
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// This event handler is used to create a new room or edit an existing room.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Check if the RoomLocation is Empty
            if (GetRoomLocation() == string.Empty)
            {
                MessageBox.Show("Room Location must not be empty", "Error");
            }
            else
            {
                // Create boolean variable
                bool valid = true;
                // Create SqlConnection
                using (SqlConnection conn = new SqlConnection(ReturnDatabaseConnection()))
                {
                    // Open the connection
                    conn.Open();
                    // Query
                    string sqlQuery = "SELECT r.ROOM_LOCATION, rt.ROOM_TYPE_ID FROM ROOM AS r JOIN ROOM_TYPE AS rt ON r.ROOM_TYPE_ID = rt.ROOM_TYPE_ID GROUP BY r.ROOM_LOCATION, rt.ROOM_TYPE_ID;";
                    // Create SqlCommand
                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        // Create SqlDataReader and execute command
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if an existing room location already exists in the database
                            while (reader.Read())
                            {
                                if (GetRoomLocation().Equals(reader.GetString(0)) && GetRoomTypeID() == reader.GetInt32(1))
                                {
                                    // Set boolean to false
                                    valid = false;
                                }
                            }
                        }
                    }
                }
                // If all input is valid
                if (valid)
                {
                    // Return DialogResult.OK as the DialogResult
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    // Show error message
                    MessageBox.Show("Room Location is already registered", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// This event handler is used to return DialogResult.Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
