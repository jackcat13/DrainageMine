﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrainageMine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Initialisation des valeurs
            coTextBox.Text = "0";
            chTextBox.Text = "0";
            waterLevelTextBox.Text = "200";
        }
    }
}
