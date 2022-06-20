using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitys;
using System.Data.SqlClient;
using System.Data;

namespace LayerOfData
{
    public class BranchOfData
    {
        DataAccess da = new DataAccess();
        Querys qs = new Querys();
        public Branch getBranch(Branch branch)
        {
            DataTable table = da.getTable(qs.getTableName(), qs.getConsultAll() + qs.getTableName() + qs.getWhereId_Branch() + Convert.ToString(branch.getId_Branch()));
            branch.setId_Branch(Convert.ToInt32(table.Rows[0][0].ToString()));
            branch.setBranchName(table.Rows[0][1].ToString());
            branch.setBranchDescription(table.Rows[0][2].ToString());
            branch.setId_BranchProvince(Convert.ToInt32(table.Rows[0][3].ToString()));
            branch.setBranchAddress(table.Rows[0][4].ToString());
            branch.setURL_BranchImagen(table.Rows[0][5].ToString());
            return branch;
        }
        public DataTable getBranchsWithoutFilter()
        {
            return da.getTable(qs.getTableName(), qs.getQueryWithoutFilter());
        }
        public DataTable getBranchsWithFilter(ref string id)
        {
            return da.getTable(qs.getTableName(), qs.getQueryWithFilter() + id + qs.getQueryWithFilterp2());
        }
        public bool existsBranch(Branch branch)
        {
            return da.exists(qs.getBranchWhere() + branch.getBranchName() + "%'");
        }
        public int deleteBranch(Branch branch)
        {
            SqlCommand command = new SqlCommand();
            armBranchDeleteParameters(ref command, branch);
            return da.executeStoredProcedure(command, "spDelete");
        }
        public int addBranch(Branch branch)
        {
            SqlCommand command = new SqlCommand();
            armBranchAddParameters(ref command, branch);
            return da.executeStoredProcedure(command, "spAddBranch");
        }
        private void armBranchDeleteParameters(ref SqlCommand command, Branch branch)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = command.Parameters.Add("@Id_Sucursal", SqlDbType.Int);
            sqlParameter.Value = branch.getId_Branch();
        }
        private void armBranchAddParameters(ref SqlCommand command, Branch branch)
        {
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = command.Parameters.Add("@NombreSucursal", SqlDbType.NVarChar);
            sqlParameter.Value = branch.getBranchName();
            sqlParameter = command.Parameters.Add("@DescripcionSucursal", SqlDbType.NVarChar);
            sqlParameter.Value = branch.getBranchDescription();
            sqlParameter = command.Parameters.Add("@Id_ProvinciaSucursal", SqlDbType.Int);
            sqlParameter.Value = branch.getId_BranchProvince();
            sqlParameter = command.Parameters.Add("@DireccionSucursal", SqlDbType.NVarChar);
            sqlParameter.Value = branch.getBranchAddress();
        }
    }
}
