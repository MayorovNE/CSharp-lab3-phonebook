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
using System.Web;
using System.Xml.Linq;
using System.Xml;

namespace lab_3_mayorov_n.e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument PhoneBook = new XmlDocument();
        List<Person> people = new List<Person>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string FileName = "C:\\Users\\user\\source\\repos\\lab 3 mayorov n.e\\lab 3 mayorov n.e\\PhoneBook.json";
            PhoneBook.Load(FileName);
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            ///   if (!Directory.Exists(path + "C:\\Users\\user\\source\\repos\\lab 3 mayorov n.e\\lab 3 mayorov n.e"))
            //    Directory.CreateDirectory(path + "C:\\Users\\user\\source\\repos\\lab 3 mayorov n.e\\lab 3 mayorov n.e");
            //if (!File.Exists(path + "C:\\Users\\user\\source\\repos\\lab 3 mayorov n.e\\lab 3 mayorov n.e\\PhoneBook.xml"))
            //    File.Create((path + "C:\\Users\\user\\source\\repos\\lab 3 mayorov n.e\\lab 3 mayorov n.e\\PhoneBook.xml"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.FirstName = textBox4.Text;
            p.Phone = textBox2.Text;

            p.DataRozhdeniya = dateTimePicker1.Value;
            p.Email = textBox3.Text;
            p.Additional = textBox1.Text;
            people.Add(p);
            listBox1.Items.Add(p.FirstName);
            textBox4.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            textBox1.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
        }
              
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItems.Count == 0)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
            }
            else
            {
                textBox4.Text = people[listBox1.SelectedIndex].FirstName;
                textBox3.Text = people[listBox1.SelectedIndex].Email;
                textBox2.Text = people[listBox1.SelectedIndex].Phone;
                dateTimePicker1.Value = people[listBox1.SelectedIndex].DataRozhdeniya;
                textBox1.Text = people[listBox1.SelectedIndex].Additional;
            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Remove();
            }
            void Remove()
            {
                try
                {
                    people.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);



                }
                catch { }

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            people[listBox1.SelectedIndex].FirstName = textBox4.Text;
            people[listBox1.SelectedIndex].Email = textBox3.Text;
            people[listBox1.SelectedIndex].Additional = textBox1.Text;
            people[listBox1.SelectedIndex].Phone = textBox2.Text;
            people[listBox1.SelectedIndex].DataRozhdeniya = dateTimePicker1.Value;
            //listBox1.SelectedItems[0].Text = textBox1.Text;

        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DataRozhdeniya { get; set; }
        public string Additional { get; set; }
    }

}

