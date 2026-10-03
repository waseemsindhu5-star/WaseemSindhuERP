namespace WaseemSindhuERP.Models;

public class LedgerEntry
{
    public int Id { get; set; }
    public DateTime EntryDate { get; set; } = DateTime.Today;
    public string AccountName { get; set; } = string.Empty;
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public string Description { get; set; } = string.Empty;
}
