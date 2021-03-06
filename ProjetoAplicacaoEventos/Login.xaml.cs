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

namespace ProjetoAplicacaoEventos
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       
        GerenciadorDeUsuarios gerenciador;

        public Login()
        {
            InitializeComponent();
            gerenciador = GerenciadorDeUsuarios.GetInstancia();
        }

        private void txNome_TextChanged(object sender, TextChangedEventArgs e)
        {
            LbError.Content = "";
        }


        private void btCriarconta_Click_1(object sender, RoutedEventArgs e)
        {
            CadastroUsuario cadastro = new CadastroUsuario(); 

            cadastro.Show();
            this.Close();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            string email;
            string senha;

            email = txEmail.Text;
            senha = txSenha.Password;


            Usuario user;

            if (gerenciador.ExisteUsuario(email))
            {
                user = gerenciador.GetUsuarioPerEmail(email);
                if (senha == user.Senha)
                {
                    MainWindow janela = new MainWindow(user);
                    janela.Show();
                    this.Close();
                }
                else
                {
                    LbError.Content = "Senha Incorreta!";
                }
            }
            else
            {
                LbError.Content = "Usuario não cadastrado!";
            }

        }
    }
}
