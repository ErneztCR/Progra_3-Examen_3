using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_3_Ernesto_Vargas.clases;

namespace Examen_3_Ernesto_Vargas
{
    public partial class llenarEncuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LabelNumEncuesta.Text = clases.ClaseAgregarUsuarioEncuesta.EncuestaID;
            LlenarCodigo();
        }

        public void alertas(String texto)
        {
            string message = texto;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        }


        //protected void LlenarCodigo()
        //{
        //    string constr = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("select EncuestaID from Encuesta"))
        //       {
        //            using (SqlDataAdapter sda = new SqlDataAdapter())
        //             {
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;
        //                using (DataTable dt = new DataTable())
        //                {
        //                    sda.Fill(dt);
        //                    LabelNumEncuesta.DataSource = dt;
        //
        //                    LabelNumEncuesta.DataValueField = dt.Columns["EncuestaID"].ToString();
        //                    LabelNumEncuesta.DataBind();
        //                }
        //            }
        //        }
        //    }
        //s }

        protected void LlenarCodigo()
        {
            string constr = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select PartidoPolitico from PartidosPoliticos"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            DropDownList1.DataSource = dt;

                            DropDownList1.DataValueField = dt.Columns["PartidoPolitico"].ToString();
                            DropDownList1.DataBind();
                        }
                    }
                }
            }
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            int resultado = ClaseAgregarUsuarioEncuesta.Agregar(TextBoxusername.Text, TextBoxFecha.Text, TextBoxemail.Text);

            if (resultado > 0)
            {
                alertas("Usuario agregado correctamente");
                TextBoxusername.Text = string.Empty;
                TextBoxemail.Text = string.Empty;
            }
            else
            {
                alertas("Error al agregar al usuario");
            }

        }
    }
}