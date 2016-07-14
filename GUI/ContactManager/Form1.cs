using System;
using System.Windows.Forms;
using System.IO;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Check if file exists
            //      if file does not exist create
            createFile();

            // Load contact from file
            loadContacts();
            
        }
        private void createFile()
        {
            string filePath = "contacts.txt";
            try
            {
                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.Close();
                    }
                }
            }
            catch (DirectoryNotFoundException exc)
            {
                Console.WriteLine(exc);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e);
            }
        }
        private void loadContacts()
        {
            StreamReader rf = new StreamReader("contacts.txt");
            string line;
            try
            {
                line = rf.ReadLine();
                while (line != null)
                {
                    listboxContacts.Items.Add(line);
                    line = rf.ReadLine();
                }
                rf.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                rf.Close();
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Output textbox to Listbox
            contactsList();
            // Output Listbox to File
            outputFile();

        }
        private void contactsList()
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            listboxContacts.Items.Add("Name: " + name);
            listboxContacts.Items.Add("Email: " + email);
            listboxContacts.Items.Add("");
            listboxContacts.SelectedIndex = listboxContacts.Items.Count - 1;
            listboxContacts.SelectedIndex = -1;
            txtName.Text = "";
            txtEmail.Text = "";
            txtName.Focus();

        }
        public void outputFile()
        {
            //string filePath = "contacts.txt";
            //using (StreamWriter sw = File.AppendText(filePath))
            StreamWriter sw = new StreamWriter("contacts.txt");
            {
                foreach (string s in listboxContacts.Items)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
