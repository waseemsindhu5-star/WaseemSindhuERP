namespace WaseemSindhuERP.Models;

public class PurchaseOrder
{
    public int Id { get; set; }
    public string OrderNumber { get; set; } = string.Empty;
    public int SupplierId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Today;
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = "Draft";
    public Supplier? Supplier { get; set; }
    public List<PurchaseOrderItem> Items { get; set; } = new();
}
