using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierDAL
    {
        private static SupplierDAL instance;
        /// <summary>
        /// Design pattern singleton
        /// </summary>
        public static SupplierDAL Instance { get => instance == null ? instance = new SupplierDAL() : instance; private set => instance = value; }

        public DataTable LoadSupplier()
        {
            return DataProvider.Instance.ExecuteQuery("select CompanyName as [Tên công ty], PhoneNumber as [Số điện thoại], Address as [Địa chỉ] from SUPPLIERS");
        }

        public int InsertSupplier(string name, string phonenumber, string address = null)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO SUPPLIERS VALUES ( @NAME, @PHONENUMBER, @ADDRESS )", new object[] {name, phonenumber, address});
        }

        public DataTable SearchingSupplier(string Name)
        {
            return DataProvider.Instance.ExecuteQuery($"EXEC SP_SupplierSearch N'%{Name}%'");
        }

        public int EditSupplier(string name, string phonenumber, string address)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE SUPPLIERS SET PhoneNumber = @PHONENUMBER, Address = @ADDRESS WHERE CompanyName = @NAME", new object[] { phonenumber, address, name });
        }

        public int DeleteSupplier(string name)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC SP_DeleteSupplier @ID, @NAME", new object[] {StockDAL.Instance.GetIDProductBySupplier(name) ,name });
        }
    }
}
