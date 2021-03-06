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
using System.Windows.Shapes;

namespace SantaTecla.WPF.Views
{
    /// <summary>
    /// Interaction logic for AdminPanelWindow.xaml
    /// </summary>
    public partial class ReceptionPanelWindow : Window
    {
        public ReceptionPanelWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new RegisterPage());
            Agregar.Click += (obj, args) => MainFrame.Navigate(new RegisterPage());
            Actualizar.Click += (obj, args) => MainFrame.Navigate(new RegisterPage(1));
            Consultar.Click += (obj, args) => MainFrame.Navigate(new InfoPage());
            Salir.Click += (sender, e) =>
             {
                 LoginPage log = new LoginPage();
                 Hide();
                 log.Show();
                 Close();
                 
             };
        }
    }
}
