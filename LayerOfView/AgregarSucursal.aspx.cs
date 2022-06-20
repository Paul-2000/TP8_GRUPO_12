using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entitys;
using LayerOfBusiness;

namespace LayerOfView
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        BranchOfBusiness business = new BranchOfBusiness();        
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if(!IsPostBack)
            {
                business.ddlCharger(ddlBranchProvince);
            }
        }
        protected void CleanControls()
        {
            txtBranchName.Text = string.Empty;
            txtBranchDescription.Text = string.Empty;
            txtBranchAddress.Text = string.Empty;
            ddlBranchProvince.Items.Insert(0, new ListItem(" -- Seleccione una provincia -- ", "0"));
        }
        protected void addBranch()
        {
            Branch branch = new Branch();
            branch.setBranchName(txtBranchName.Text.Trim());
            branch.setBranchDescription(txtBranchDescription.Text.Trim());
            branch.setId_BranchProvince(ddlBranchProvince.SelectedIndex);
            branch.setBranchAddress(txtBranchAddress.Text.Trim());
            if (business.addBranch(branch)) lbResult.Text = "¡Se agregó la sucursal correctamente!";
            else lbResult.Text = "¡Hubo un problema al agregar la sucursal!";
        }
        protected void btnAccept_Click(object sender, EventArgs e)
        {
            addBranch();
            CleanControls();
        }
    }
}