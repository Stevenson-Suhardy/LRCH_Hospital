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
    public partial class AddEditRoomType : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public AddEditRoomType()
        {
            InitializeComponent();
        }
        #endregion

        #region Getters and Setters
        public string GetRoomType()
        {
            return textBoxRoomType.Text;
        }

        public void SetRoomType(string roomType)
        {
            textBoxRoomType.Text = roomType;
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Check if the RoomLocation is Empty
            if (GetRoomType() == string.Empty)
            {
                MessageBox.Show("Room Type must not be empty", "Error");
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
                    string sqlQuery = "SELECT ROOM_TYPE_DESCRIPTION FROM ROOM_TYPE;";
                    // Create SqlCommand
                    using (SqlCommand command = new SqlCommand(sqlQuery, conn))
                    {
                        // Create SqlDataReader and execute command
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if an existing room location already exists in the database
                            while (reader.Read())
                            {
                                if (GetRoomType().Equals(reader.GetString(0)))
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
                    MessageBox.Show("Room Type is already registered", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion
    }
}
