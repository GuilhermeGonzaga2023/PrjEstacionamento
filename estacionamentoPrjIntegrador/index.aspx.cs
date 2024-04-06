using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace estacionamentoPrjIntegrador
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
            
        }

        protected void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings
                ["estacionamentoPrjIntegrador.Properties.Settings.strConexao"].ToString());

                SqlCommand cmd = new SqlCommand();
                SqlDataReader leitor;

                cmd.CommandText = "ps_validaLoginUsu";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conexao;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("nomeUsu", txtLogin.Text);
                cmd.Parameters.AddWithValue("SenhaUsu", txtSenha.Text);
                conexao.Open();
                leitor = cmd.ExecuteReader();

                if (leitor.HasRows)
                {
                    leitor.Read();
                    conexao.Close();
                    leitor.Close();
                    Response.Redirect("estacionamento.aspx");
                }

                else
                {
                    conexao.Close();
                    leitor.Close();
                    msgErro.Text = "dados errados";
                }

            }
            catch (Exception ex)
            {
                msgErro.Text=ex.Message;
                
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
              Response.Redirect("cadastro.aspx");
        }
    }
}