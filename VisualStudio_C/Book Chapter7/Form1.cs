﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualStudio_C.Book_Chapter7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Thread t = new Thread(DoLongOperation);
            t.Start();
        }

        void DoLongOperation() {
            Thread.Sleep(5000);
        }
    }
}
