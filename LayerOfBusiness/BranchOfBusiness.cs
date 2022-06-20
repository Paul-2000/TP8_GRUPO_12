using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using LayerOfData;
using System.Data;
using Entitys;

namespace LayerOfBusiness
{
    public class BranchOfBusiness
    {
        public DataTable getTableWithoutFilter()
        {
            BranchOfData data = new BranchOfData();
            return data.getBranchsWithoutFilter();
        }
        public DataTable getTableWithFilter(string id)
        {
            BranchOfData data = new BranchOfData();
            return data.getBranchsWithFilter(ref id);
        }
        public bool getExists(string id)
        {
            DataAccess da = new DataAccess();
            Querys qs = new Querys();
            if (da.ExecuteReader(qs.getConsultAll() + qs.getTableName() + qs.getWhereId_Branch() + id) != -1) return true;
            else return false;
        }
        public Branch GetBranch(int id)
        {
            BranchOfData data = new BranchOfData();
            Branch branch = new Branch();
            branch.setId_Branch(id);
            return data.getBranch(branch);
        }
        public bool deleteBranch(string id)
        {
            BranchOfData data = new BranchOfData();
            Branch branch = new Branch();
            branch.setId_Branch(Convert.ToInt32(id));
            if (data.deleteBranch(branch) == 1) return true;
            else return false;
        }
        public bool addBranch(string name)
        {
            int cantRows = 0;
            BranchOfData data = new BranchOfData();
            Branch branch = new Branch();
            branch.setBranchName(name);
            if (data.existsBranch(branch)) cantRows = data.addBranch(branch);
            if (cantRows == 1) return true;
            else return false;
        }
        public bool addBranch(Branch branch)
        {
            int cantRows = 0;
            BranchOfData data = new BranchOfData();
            if (!data.existsBranch(branch)) cantRows = data.addBranch(branch);
            if (cantRows == 1) return true;
            else return false;
        }
        public void ddlCharger(DropDownList ddl)
        {
            Querys qs = new Querys();
            DataAccess da = new DataAccess();
            ddl.DataSource = da.ddlCharger(qs.getProvince());
            ddl.DataValueField = qs.getId_Province();
            ddl.DataTextField = qs.getDescriptionProvince();
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem(" -- Seleccione una provincia -- ", "0"));
        }
    }
}
