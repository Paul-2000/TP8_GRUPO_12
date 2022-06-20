using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerOfBusiness;

namespace LayerOfView
{
    public partial class ListarSucursal : System.Web.UI.Page
    {
        BranchOfBusiness business = new BranchOfBusiness();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadTable();
        }
        protected void LoadTable()
        {
            lbMessage.Text = string.Empty;
            txtIdBranch.Text = string.Empty;
            grdTable.Visible = true;
            grdTable.DataSource = business.getTableWithoutFilter();
            grdTable.DataBind();
        }
        protected void TableWithFilter()
        {
            if (txtIdBranch.Text.Trim() != string.Empty)
            {
                string id = Convert.ToString(txtIdBranch.Text.Trim());
                if (business.getExists(id))
                {
                    grdTable.DataSource = business.getTableWithFilter(id);
                    grdTable.DataBind();
                    lbMessage.Text = string.Empty;
                    grdTable.Visible = true;
                }
                else
                {
                    lbMessage.Text = "No Existe el ID ingresado.";
                    grdTable.Visible = false;
                }
            }
            else
            {
                lbMessage.Text = "Debe de Ingresar un ID por favor.";
                grdTable.Visible = false;
            }
            txtIdBranch.Text = string.Empty;
        }
        protected void btnFilter_Click(object sender, EventArgs e)
        {
            TableWithFilter();
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadTable();
        }
    }
}