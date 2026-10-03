namespace WaseemSindhuERP.Models;

public class SalesOrder
{
    public int Id { get; set; }
    public string OrderNumber { get; set; } = string.Empty;
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Today;
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = "Draft";
    public Customer? Customer { get; set; }
    public List<SalesOrderItem> Items { get; set; } = new();
}
