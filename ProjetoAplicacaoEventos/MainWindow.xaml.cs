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

namespace ProjetoAplicacaoEventos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Usuario usuario;

        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            label.Content = usuario.Nome;
        }
    }
}
