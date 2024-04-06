using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace estacionamentoPrjIntegrador
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings
                ["estacionamentoPrjIntegrador.Properties.Settings.strConexao"].ToString());

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "pi_Usuario";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conexao;

                if (txtNome.Text == "" || txtSenha.Text == "")
                {
                    msgErro.Text = "preencha os campos corretamente";
                    txtNome.Text = "";
                    txtSenha.Text = "";

                }
                else
                {
                    cmd.Parameters.AddWithValue("nomeUsu", txtNome.Text);
                    cmd.Parameters.AddWithValue("senhaUsu", txtSenha.Text);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    msgErro.Text = "usuario registrado com sucesso";
                    txtNome.Text = "";
                    txtSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                msgErro.Text = ex.Message;
                txtNome.Text = "";
                txtSenha.Text = "";
            }

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}