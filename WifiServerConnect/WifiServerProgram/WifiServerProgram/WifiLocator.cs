using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace WifiServerProgram
{
    public partial class WifiLocator : Form
    {


        public WifiLocator()
        {
            InitializeComponent();
        }

        private void sendToServerButton_Click(object sender, EventArgs e)
        {
            if (userIdText.Text == "" || firstNameText.Text == "" || emailText.Text == "" || macAddressText.Text == "" || lastNameText.Text == "" || passwordText.Text == "")
            {
                sendReport.Text = "Fill in all the required information!";
            }
            else if (userIdText.Text.Contains("Enter ") || firstNameText.Text.Contains("Enter ") || emailText.Text.Contains("Enter ") || macAddressText.Text.Contains("Enter ") || lastNameText.Text.Contains("Enter ") || passwordText.Text.Contains("Enter "))
            {
                sendReport.Text = "Actually enter in some information...";
            }
            else
            {
                try
                {
                    String command = "INSERT INTO UserTable (userID,password,userMacAddress,firstName,lastName,email,isAdmin) VALUES('" +
                    userIdText.Text + "','" + passwordText.Text + "','" + macAddressText.Text + "','" + firstNameText.Text + "','" + lastNameText.Text + "','" + emailText.Text + "','N')";

                    MySqlConnection connection;
                    string server;
                    string database;
                    string uid;
                    string password;

                    server = "mintaka.lynchburg.edu";
                    database = "WifiLocDja";
                    uid = "darrius_c";
                    password = "fool7BREW";
                    string connectionString;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                    sendReport.Text = "Connecting...";
                    connection = new MySqlConnection(connectionString);
                    //open connection
                    connection.Open();               
                    
                    if (connection.State.Equals(ConnectionState.Open))
                    {
                        sendReport.Text = "Connection open, executing command...";
                        slave.Text = command;
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(command, connection);
                        //Execute command
                        cmd.ExecuteNonQuery();

                        //Test #6
                        sendReport.Text = "Success! Executed query: " + command;
                        connection.Close();
                    }


                }
                catch (Exception badError)
                {
                    Console.WriteLine("Error..... " + badError.StackTrace);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accessPointName.Text == "" || signalStrength.Text == "" || ssid.Text == "" || accessPointMacAddress.Text == "")
            {
                locationInfoLabel.Text = "Fill in all the required information!";
            }
            else if (accessPointName.Text.Contains("Enter ") || signalStrength.Text.Contains("Enter ") || ssid.Text.Contains("Enter ") || accessPointMacAddress.Text.Contains("Enter "))
            {
                locationInfoLabel.Text = "Actually enter in some information...";
            }
            else if (userIdText.Text == "" || userIdText.Text.Contains("Enter "))
            {
                locationInfoLabel.Text = "User ID not entered (change above)";
            }
            else
            {
                try
                {
                    String command = "INSERT INTO locations (accessPointName,signalStrength,macAddress,ssid,userID) VALUES('" +
                    accessPointName.Text + "','" + signalStrength.Text + "','" + accessPointMacAddress.Text + "','" + ssid.Text + "','" + userIdText.Text + "')";

                    MySqlConnection connection;
                    string server;
                    string database;
                    string uid;
                    string password;

                    server = "mintaka.lynchburg.edu";
                    database = "WifiLocDja";
                    uid = "darrius_c";
                    password = "fool7BREW";
                    string connectionString;
                    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                    locationInfoLabel.Text = "Connecting...";
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    if (connection.State.Equals(ConnectionState.Open))
                    {
                        locationInfoLabel.Text = "Connection open, executing command...";
                        //open connection
                        //create command and assign the query and connection from the constructor
                        MySqlCommand cmd = new MySqlCommand(command, connection);

                        //Execute command
                        cmd.ExecuteNonQuery();

                        //Test #8
                        locationInfoLabel.Text = "Success! Executed query: " + command;
                        connection.Close();
                    }


                }
                catch (Exception badError)
                {
                    Console.WriteLine("Error..... " + badError.StackTrace);
                }
            }
        }

        private void userIdText_Click(object sender, EventArgs e)
        {
            userIdText.Text = "";
        }

        private void passwordText_Click(object sender, EventArgs e)
        {
            passwordText.Text = "";
        }

        private void macAddressText_Click(object sender, EventArgs e)
        {
            macAddressText.Text = "";
        }

        private void firstNameText_Click(object sender, EventArgs e)
        {
            firstNameText.Text = "";
        }

        private void lastNameText_Click(object sender, EventArgs e)
        {
            lastNameText.Text = "";
        }

        private void emailText_Click(object sender, EventArgs e)
        {
            emailText.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            accessPointName.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            signalStrength.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            ssid.Text = "";
        }
           
        private void accessPointMacAddress_Click(object sender, EventArgs e)
        {
            accessPointMacAddress.Text = "";
        }

    }
}
