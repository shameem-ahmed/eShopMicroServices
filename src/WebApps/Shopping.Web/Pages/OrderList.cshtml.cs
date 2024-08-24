using Shopping.Web.Services;

namespace Shopping.Web.Pages;
public class OrderListModel(IOrderingService orderingService, ILogger<ProductListModel> logger) : PageModel
{
    public IEnumerable<OrderModel> Orders { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync()
    {
        //assumption: customerId v. authentication, take id from InitialData.cs for now
        var customerId = new Guid("01b82b87-f3f7-4fec-920c-facfe18e11e9");
        var response = await orderingService.GetOrdersByCustomer(customerId);
        Orders = response.Orders;

        return Page();
    }
}
