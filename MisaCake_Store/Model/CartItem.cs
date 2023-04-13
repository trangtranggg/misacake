namespace MisaCake_Store.Model
{
    public class CartItem
    {
        public CartItem(int quantity, Cake cake)
        {
            this.quantity = quantity;
            this.cake = cake;
        }

        public int quantity { set; get; }
        public Cake cake { set; get; }
    }
}
