using MisaCake_Store.Model;
namespace MisaCake_Store.DBContext
{
    public class DBContext
    {
        private static DBContext _ins;
        public static DBContext Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new DBContext();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }

        public Cake_SellerContext DB { get; set; }
        public DBContext()
        {
            DB = new Cake_SellerContext();
        }
    }

}
