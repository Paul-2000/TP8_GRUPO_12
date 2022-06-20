using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LayerOfBusiness;

namespace LayerOfView
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        BranchOfBusiness business = new BranchOfBusiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdBranch.Text.Trim() != string.Empty)
            {
                string id = Convert.ToString(txtIdBranch.Text.Trim());
                if (business.getExists(id) && business.deleteBranch(id))
                {
                    lbMessage.Text = "La sucursal se ha eliminado con éxito.";
                }
                else
                {
                    lbMessage.Text = "No Existe el ID ingresado.";
                }
            }
            else
            {
                lbMessage.Text = "Debe de Ingresar un ID por favor.";
            }
            txtIdBranch.Text = string.Empty;
        }
    }
}