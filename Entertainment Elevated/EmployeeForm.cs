﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entertainment_Elevated
{
    public partial class EmployeeForm : Form
    {
        private List<Employee> Employees = new List<Employee>();
        public EmployeeForm()
        {
            InitializeComponent();
        }
    }
}