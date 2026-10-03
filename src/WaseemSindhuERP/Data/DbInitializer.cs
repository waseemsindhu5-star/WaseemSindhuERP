using Microsoft.EntityFrameworkCore;
using WaseemSindhuERP.Models;

namespace WaseemSindhuERP.Data;

public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        context.Database.EnsureCreated();

        if (context.Companies.Any())
        {
            return;
        }

        var company = new Company
        {
            Name = "Waseem Sindhu ERP",
            Address = "Main Business District",
            Phone = "+92 300 0000000",
            Email = "admin@waseemsindhuerp.com",
            IsActive = true
        };

        var adminUser = new UserAccount
        {
            UserName = "admin",
            PasswordHash = "admin123",
            FullName = "System Administrator",
            Role = "Admin",
            IsActive = true
        };

        var customer1 = new Customer
        {
            Name = "Ali Traders",
            Phone = "0300-1111111",
            Address = "Lahore",
            CreditLimit = 50000,
            CurrentBalance = 15000
        };

        var customer2 = new Customer
        {
            Name = "Punjab Retail", 
            Phone = "0300-2222222",
            Address = "Karachi",
            CreditLimit = 75000,
            CurrentBalance = 20000
        };

        var supplier1 = new Supplier
        {
            Name = "Atlas Supply Co.",
            Phone = "0300-3333333",
            Address = "Faisalabad"
        };

        var product1 = new Product
        {
            Name = "Packaging Box",
            Barcode = "PKG-1001",
            Category = "Packaging",
            Unit = "Box",
            CostPrice = 120,
            SalePrice = 180,
            StockQuantity = 250
        };

        var product2 = new Product
        {
            Name = "Plastic Roll",
            Barcode = "PLR-2002",
            Category = "Raw Material",
            Unit = "Roll",
            CostPrice = 240,
            SalePrice = 320,
            StockQuantity = 180
        };

        var ledger1 = new LedgerEntry
        {
            EntryDate = DateTime.Today,
            AccountName = "Cash",
            Debit = 15000,
            Credit = 0,
            Description = "Opening cash balance"
        };

        var ledger2 = new LedgerEntry
        {
            EntryDate = DateTime.Today,
            AccountName = "Sales",
            Debit = 0,
            Credit = 12000,
            Description = "Invoice payment received"
        };

        context.Companies.Add(company);
        context.UserAccounts.Add(adminUser);
        context.Customers.AddRange(customer1, customer2);
        context.Suppliers.Add(supplier1);
        context.Products.AddRange(product1, product2);
        context.LedgerEntries.AddRange(ledger1, ledger2);

        context.SaveChanges();
    }
}
