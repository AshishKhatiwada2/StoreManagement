using StoreManagement.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<StoreManagement.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<StoreManagement.Models.Bill> Bill { get; set; }

        public DbSet<StoreManagement.Models.BillType> BillType { get; set; }

        public DbSet<StoreManagement.Models.Branch> Branch { get; set; }

        public DbSet<StoreManagement.Models.CashBank> CashBank { get; set; }

        public DbSet<StoreManagement.Models.Currency> Currency { get; set; }

        public DbSet<StoreManagement.Models.Customer> Customer { get; set; }

        public DbSet<StoreManagement.Models.CustomerType> CustomerType { get; set; }

        public DbSet<StoreManagement.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<StoreManagement.Models.Invoice> Invoice { get; set; }

        public DbSet<StoreManagement.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<StoreManagement.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<StoreManagement.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<StoreManagement.Models.PaymentType> PaymentType { get; set; }

        public DbSet<StoreManagement.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<StoreManagement.Models.Product> Product { get; set; }

        public DbSet<StoreManagement.Models.ProductType> ProductType { get; set; }

        public DbSet<StoreManagement.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<StoreManagement.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<StoreManagement.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<StoreManagement.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<StoreManagement.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<StoreManagement.Models.SalesType> SalesType { get; set; }

        public DbSet<StoreManagement.Models.Shipment> Shipment { get; set; }

        public DbSet<StoreManagement.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<StoreManagement.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<StoreManagement.Models.Vendor> Vendor { get; set; }

        public DbSet<StoreManagement.Models.VendorType> VendorType { get; set; }

        public DbSet<StoreManagement.Models.Warehouse> Warehouse { get; set; }

        public DbSet<StoreManagement.Models.UserProfile> UserProfile { get; set; }
    }
}
