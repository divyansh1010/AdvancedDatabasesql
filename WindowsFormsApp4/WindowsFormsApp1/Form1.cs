using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "My Awesome Application";

            this.Width = 700;

        }

        private void createOurTable() {

            TableLayoutPanel myTable = new TableLayoutPanel();

            myTable.Location = new Point(18, 18);

            int myTableWidth, myTableHeight;


            myTableHeight = 150;

            myTableWidth = 400;
            myTable.Size = new Size(myTableWidth, myTableHeight);

            int numberOfColumns = 3;

            myTable.ColumnCount = numberOfColumns;

            //Our data is 3x3

            string[,] ourData = new string[,] {
                { "Ben", "18", "C#" },
                { "Bob", "21", "ASP" },
                { "Joe", "25", "Database" },
                { "Mary", "20", "Java" },

            };

            int numberOfRows = 5;

            numberOfRows = ourData.GetUpperBound(0) + 2;

            myTable.RowCount = numberOfRows;

            // MessageBox.Show("The amount of rows is "+ numberOfRows.ToString());

            for (int i = 0; i < numberOfColumns; i++) {

                myTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            }


            float heightOfEachRow = myTableHeight / numberOfRows;
            for (int i = 0; i < numberOfRows; i++) {

                myTable.RowStyles.Add(new RowStyle(SizeType.Absolute, heightOfEachRow));
            }

            myTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;


            string textToWrite = "";

            string[] headers = { "Name", "Age", "Subject" };

            for (int x = 0; x < numberOfColumns; x++) {


                for (int y = 0; y < numberOfRows; y++) {

                    Label textContent = new Label();

                    if (y == 0) {

                        textToWrite = headers[x];
                    }
                    else {

                        textToWrite = ourData[y - 1, x];
                    }

                    textContent.Text = textToWrite;

                    myTable.Controls.Add(textContent, x, y);

                }
            }


            splitContainer2.Panel2.Controls.Add(myTable);

        }

        private void display_database() {

            /*
             * 
             * Create a table called Bags
             *      It has the following fields
             *          id, name, numstraps => is a foreign key  
             * 
             * Create another tables called straps
             *      Is has the following fields
             *          id, amountOfStraps
             *          
             * Populate both tables with 3 rows 
             */

            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Benny Boom\source\repos\WindowsFormsApp4\WindowsFormsApp1\Database1.mdf'; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = "select * from Students";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {

                MessageBox.Show("ID = " + reader.GetInt32(0).ToString() + "FirstName = " + reader.GetString(1) + "LastName = " + reader.GetString(2) + "Grade Percentage = " + reader.GetInt32(3).ToString());

            }
            connection.Close();
        }


        private void insert_into_database() {

            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Benny Boom\source\repos\WindowsFormsApp4\WindowsFormsApp1\Database1.mdf'; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string query = "INSERT INTO Students (FirstName, LastName, GradesPercentage) VALUES (@FN, @LN, @GP)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add(new SqlParameter("FN", "PHP"));
            command.Parameters.Add(new SqlParameter("LN", "Project"));
            command.Parameters.Add(new SqlParameter("GP", 1));

            command.ExecuteNonQuery();

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.database1DataSet.Students);
            //insert_into_database();
           // display_database();
            showPage4();
            createOurTable();

            comboBox2.Items.Add("Add this item");
            comboBox2.Items.Add("Second Item");

            comboBox2.Items.Insert(0, "Overriding first spot");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showPage1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            showPage2();

        }

        private void firstPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage1();

        }

        private void showPage1()
        {
            panel1.Visible = true;
            panel2.Visible = false;
            splitContainer1.Visible = false;
            splitContainer2.Visible = false;

        }
        private void showPage2() {
            panel1.Visible = false;
            panel2.Visible = true;
            splitContainer1.Visible = false;
            splitContainer2.Visible = false;

        }
        private void showPage3()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            splitContainer1.Visible = true;
            splitContainer2.Visible = false;

        }
        private void showPage4()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            splitContainer1.Visible = false;
            splitContainer2.Visible = true;

        }
        private void secondPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage2();
        }

        private void thirdPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage3();
        }

        private void openDialogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.Title = "Choose a file to open";


            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                MessageBox.Show(openFileDialog1.FileName);

                MessageBox.Show(File.ReadAllText(openFileDialog1.FileName));

            }

        }

        private void saveDialogueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.CheckPathExists = true;

            saveFileDialog1.Title = "Choose a file to save";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show(saveFileDialog1.FileName);

            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            string email = textBox3.Text;
            string comment = textBox4.Text;

            if (firstname.Length > 0 && lastname.Length > 0 && email.Length > 0 && comment.Length > 0)
            {

                MessageBox.Show("You have filled in the form correctly");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                showPage1();
            }
            else {

                MessageBox.Show("You have errors on you form!");

            }

        }

        private void fourthPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage4();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(  comboBox1.SelectedText );
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            if(comboBox1.SelectedValue != null)
                MessageBox.Show(comboBox1.SelectedValue.ToString());

        }

    }
}
