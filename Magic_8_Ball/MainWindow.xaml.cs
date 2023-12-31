﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Magic_8_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Answer { 
            get { return AnswerTextBox.Text; }
            set { AnswerTextBox.Text = value; } 
        }

        public event EventHandler<EventArgs> GotQuestion;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GotQuestion.Invoke(this, EventArgs.Empty);
        }
    }
}
