namespace Ordering.Infrastructure.Data.Extensions;

public class InitialData
{
    public static IEnumerable<Customer> Customers =>
        new List<Customer>
        {
            Customer.Create(CustomerId.Of(new Guid("01b82b87-f3f7-4fec-920c-facfe18e11e9")), "Shameem", "shameem.net1@gmail.com"),
            Customer.Create(CustomerId.Of(new Guid("92fe24d0-1f9c-4d91-8b4e-50318ebcc99d")), "Shehbaz", "shehbaz777@apple.com"),
        };

    public static IEnumerable<Product> Products =>
      new List<Product>
      {
            Product.Create(ProductId.Of(new Guid("4c0e95f7-07ab-4a07-9535-f5edd3e34ce3")), "IPhone X", 500),
            Product.Create(ProductId.Of(new Guid("0931bbbc-7335-4b84-8111-2abb1344c536")), "Samsung 10", 400),
            Product.Create(ProductId.Of(new Guid("819895da-e6b9-45aa-b906-d473983f119d")), "Huawei Plus", 650),
            Product.Create(ProductId.Of(new Guid("6beda652-22c4-4a37-8cec-f05960ea4de1")), "Xiaomi Mi", 450)
      };

    public static IEnumerable<Order> Orders
    {
        get 
         {
            var address1 = Address.Of("Shameem", "Ahmed", "shameem.net1@gmail.com", "#13, Khazi Saheb Street", "India", "TN", "Chennai", "60012");
            var address2 = Address.Of("Shehbaz", "Akthar", "shehbaz777@apple.com", "#8, MK Garden Street", "India", "TN", "Chennai", "60001");

            var payment1 = Payment.Of("Shameem", "1111222233334444", "12/28", "123", 1);
            var payment2 = Payment.Of("Shehbaz", "5555666677778888", "12/28", "789", 2);

            var order1 = Order.Create(
                OrderId.Of(new Guid("726490a9-bf1c-4e26-b5a0-f192363521c8")),
                CustomerId.Of(new Guid("01b82b87-f3f7-4fec-920c-facfe18e11e9")),
                OrderName.Of("O0001"),
                shippingAddress: address1,
                billingAddress: address1,
                payment1);

            order1.AddItem(ProductId.Of(new Guid("4c0e95f7-07ab-4a07-9535-f5edd3e34ce3")), 2, 500);
            order1.AddItem(ProductId.Of(new Guid("0931bbbc-7335-4b84-8111-2abb1344c536")), 1, 400);

            var order2 = Order.Create(
                         OrderId.Of(new Guid("05d54ccc-c27f-477a-82ed-9a88605eec74")),
                         CustomerId.Of(new Guid("92fe24d0-1f9c-4d91-8b4e-50318ebcc99d")),
                         OrderName.Of("O0002"),
                         shippingAddress: address2,
                         billingAddress: address2,
                         payment2);

            order2.AddItem(ProductId.Of(new Guid("819895da-e6b9-45aa-b906-d473983f119d")), 4, 650);
            order2.AddItem(ProductId.Of(new Guid("6beda652-22c4-4a37-8cec-f05960ea4de1")), 3, 450);

            return new List<Order> { order1, order2 };
        }
    } 
}
