using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StockDAL
    {
        private static StockDAL instance;
        /// <summary>
        /// Design pattern singleton
        /// </summary>
        public static StockDAL Instance { get => instance == null ? instance = new StockDAL() : instance; private set => instance = value; }

        public DataTable LoadProduct()
        {
            return DataProvider.Instance.ExecuteQuery(@"select ProductName as [Tên sản phẩm], Count as [Số lượng], Unit as [Đơn vị tính], Price as [Giá tiền], TimeImport as [Ngày nhập hàng], SupplierName as [Nhà cung cấp] from STOCK");
        }

        public int InsertProduct(string productname, int count, string unit, double price, DateTime dateimport, string supplier, string userid)
        {
            return DataProvider.Instance.ExecuteNonQuery("SP_AddProduct @NAME, @CNT, @UNIT, @PRICE, @TIME, @SUPPLIER, @USERID", new object[] { productname, count, unit, price, dateimport, supplier, userid });
        }

        public int EditProduct(string productname, int count, string unit, double price, DateTime dateimport, string supplier)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE STOCK SET ProductName = @NAME, Count = @CNT, Unit = @UNIT, Price = @PRICE, TimeImport = @TIME WHERE SupplierName = @SUPPLIER", new object[] { productname, count, unit, price, dateimport, supplier });

        }

        public int GetIDProductBySupplier(string supplier)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT ID FROM STOCK WHERE SupplierName = @SUPPLIER", new object[] { supplier });
            }
            catch
            {
                return -1;
            }
        }

        public int DeleteProduct(string supplier)
        {
            return DataProvider.Instance.ExecuteNonQuery("EXEC SP_DeleteProduct @ID", new object[] { GetIDProductBySupplier(supplier) });
        }

        public DataTable History()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT ID, ProductName AS [Tên sản phẩm], Count as [Số lượng], Unit as [Đơn vị tính], Price as [Giá tiền], TimeImport as [Ngày nhập hàng], SupplierName as [Tên nhà cung cấp], DisplayName as [Nhân viên nhập hàng] FROM History");
        }
    }
}
