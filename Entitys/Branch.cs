using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Branch
    {
        private int Id_Branch;
        private string BranchName;
        private string BranchDescription;
        private int Id_BranchSchudele;
        private int Id_BranchProvince;
        private string BranchAddress;
        private string URL_BranchImagen;
        public Branch() { }
        public void setId_Branch(int id) { Id_Branch = id; }
        public void setBranchName(string name) { BranchName = name; }
        public void setBranchDescription(string desc) { BranchDescription = desc; }
        public void setId_BranchProvince(int idPro) { Id_BranchProvince = idPro; }
        public void setBranchAddress(string address) { BranchAddress = address; }
        public void setURL_BranchImagen(string URL) { URL_BranchImagen = URL; }
        public int getId_Branch() { return Id_Branch; }
        public string getBranchName() { return BranchName; }
        public string getBranchDescription() { return BranchDescription; }
        public int getId_BranchProvince() { return Id_BranchProvince; }
        public string getBranchAddress() { return BranchAddress; }
        public string getURL_BranchImagen() { return URL_BranchImagen; }
    }
}
