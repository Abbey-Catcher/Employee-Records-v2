using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace EmployeeRecords
{
    public partial class mainForm : Form
    {
        List<Employee> employeeDB = new List<Employee>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string id, firstName, lastName, date, salary;

            id = idInput.Text;
            firstName = fnInput.Text;
            lastName = lnInput.Text;
            date = dateInput.Text;
            salary = salaryInput.Text;

            Employee newEmp = new Employee(id, firstName, lastName, date, salary);
            employeeDB.Add(newEmp);

            ClearLabels();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in employeeDB)
            {
                outputLabel.Text += $"{emp.id} {emp.firstName} {emp.lastName} {emp.date} {emp.salary}";
            }
        }

        private void ClearLabels()
        {
            idInput.Text = "";
            fnInput.Text = "";
            lnInput.Text = "";
            dateInput.Text = "";
            salaryInput.Text = "";
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public void loadDB()
        {
            
        }

        public void saveDB()
        {

        }
    }
}
