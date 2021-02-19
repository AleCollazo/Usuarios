using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Usuarios", ConfigurationManager.ConnectionStrings["conUsers"].ConnectionString);
            DataSet ds = new DataSet();
            da.Fill(ds, "dbo.Usuarios");
            GridView1.DataSource = ds.Tables["dbo.Usuarios"].DefaultView;
            GridView1.DataBind();

            
        }
    }
}