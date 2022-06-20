using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerOfData
{
    public class Querys
    {
        private string tableName = "Sucursal";
        private string consultAll = "SELECT * FROM ";
        private string whereId_Branch = " WHERE Id_Sucursal = ";
        private string branchWhere = "SELECT * FROM Sucursal WHERE NombreSucursal LIKE '";
        private string maxBranch = "SELECT MAX(Id_Sucursal) FROM Sucursal";
        private string Province = "SELECT * FROM Provincia";
        private string Id_Province = "Id_Provincia";
        private string DescriptionProvince = "DescripcionProvincia";
        private string queryWithoutFilter = "SELECT SU.Id_Sucursal, SU.NombreSucursal, SU.DescripcionSucursal AS Descripcion, PRO.DescripcionProvincia AS Provincia, " +
            "SU.DireccionSucursal AS Direccion FROM Sucursal AS SU INNER JOIN Provincia AS PRO ON SU.Id_ProvinciaSucursal = PRO.Id_Provincia;";
        private string queryWithFilter = "SELECT SU.Id_Sucursal, SU.NombreSucursal, SU.DescripcionSucursal AS Descripcion, PRO.DescripcionProvincia AS Provincia, " +
            "SU.DireccionSucursal AS Direccion FROM Sucursal AS SU, Provincia AS PRO WHERE Id_Sucursal = ";
        private string queryWithFilterp2 = " AND PRO.Id_Provincia = SU.Id_ProvinciaSucursal;";
        public string getTableName() { return tableName; }
        public string getConsultAll() { return consultAll; }
        public string getWhereId_Branch() { return whereId_Branch; }
        public string getBranchWhere() { return branchWhere; }
        public string getMaxBranch() { return maxBranch; }
        public string getProvince() { return Province; }
        public string getId_Province() { return Id_Province; }
        public string getDescriptionProvince() { return DescriptionProvince; }
        public string getQueryWithoutFilter() { return queryWithoutFilter; }
        public string getQueryWithFilter() { return queryWithFilter; }
        public string getQueryWithFilterp2() { return queryWithFilterp2; }
    }
}
