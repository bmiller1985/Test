﻿

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "EntityFramework.Reverse.POCO.Generator\App.config"
//     Connection String Name: "MyDbContextSqlCE4"
//     Connection String:      "Data Source=S:\Source (open source)\EntityFramework Reverse POCO Code Generator\EntityFramework.Reverse.POCO.Generator\App_Data\NorthwindSqlCe40.sdf"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace EntityFramework_Reverse_POCO_Generator.SqlCe4
{
    // ************************************************************************
    // Unit of work
    public interface IMyDbContextSqlCE4 : IDisposable
    {
        IDbSet<Category> Categories { get; set; } // Categories
        IDbSet<Customer> Customers { get; set; } // Customers
        IDbSet<Employee> Employees { get; set; } // Employees
        IDbSet<Order> Orders { get; set; } // Orders
        IDbSet<OrderDetail> OrderDetails { get; set; } // Order Details
        IDbSet<Product> Products { get; set; } // Products
        IDbSet<Shipper> Shippers { get; set; } // Shippers
        IDbSet<Supplier> Suppliers { get; set; } // Suppliers

        int SaveChanges();
    }

    // ************************************************************************
    // Database context
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class MyDbContextSqlCE4 : DbContext, IMyDbContextSqlCE4
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<Category> Categories { get; set; } // Categories

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<Customer> Customers { get; set; } // Customers

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<Employee> Employees { get; set; } // Employees

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<Order> Orders { get; set; } // Orders

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<OrderDetail> OrderDetails { get; set; } // Order Details

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<Product> Products { get; set; } // Products

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<Shipper> Shippers { get; set; } // Shippers

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public IDbSet<Supplier> Suppliers { get; set; } // Suppliers

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        static MyDbContextSqlCE4()
        {
            Database.SetInitializer<MyDbContextSqlCE4>(null);
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MyDbContextSqlCE4()
            : base("Name=MyDbContextSqlCE4")
        {
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MyDbContextSqlCE4(string connectionString) : base(connectionString)
        {
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public MyDbContextSqlCE4(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new ShipperConfiguration());
            modelBuilder.Configurations.Add(new SupplierConfiguration());
        }

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new EmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new ProductConfiguration(schema));
            modelBuilder.Configurations.Add(new ShipperConfiguration(schema));
            modelBuilder.Configurations.Add(new SupplierConfiguration(schema));
            return modelBuilder;
        }
    }

    // ************************************************************************
    // Fake Database context
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class FakeMyDbContextSqlCE4 : IMyDbContextSqlCE4
    {
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Employee> Employees { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<OrderDetail> OrderDetails { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Shipper> Shippers { get; set; }
        public IDbSet<Supplier> Suppliers { get; set; }

        public FakeMyDbContextSqlCE4()
        {
            Categories = new FakeDbSet<Category>();
            Customers = new FakeDbSet<Customer>();
            Employees = new FakeDbSet<Employee>();
            Orders = new FakeDbSet<Order>();
            OrderDetails = new FakeDbSet<OrderDetail>();
            Products = new FakeDbSet<Product>();
            Shippers = new FakeDbSet<Shipper>();
            Suppliers = new FakeDbSet<Supplier>();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException(); 
        }
    }

    // ************************************************************************
    // Fake DbSet
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class FakeDbSet<T> : IDbSet<T> where T : class
    {
        private readonly HashSet<T> _data;

        public FakeDbSet()
        {
            _data = new HashSet<T>();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public void Detach(T item)
        {
            _data.Remove(item);
        }

        Type IQueryable.ElementType
        {
            get { return _data.AsQueryable().ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return _data.AsQueryable().Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _data.AsQueryable().Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public ObservableCollection<T> Local
        {
            get
            {
                return new ObservableCollection<T>(_data);
            }
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }
    }

    // ************************************************************************
    // POCO classes

    // Categories
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class Category
    {

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int CategoryId { get; set; } // Category ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string CategoryName { get; set; } // Category Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Description { get; set; } // Description

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public byte[] Picture { get; set; } // Picture

        // Reverse navigation
        public virtual ICollection<Product> Products { get; set; } // Products.Products_FK01
        
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public Category()
        {
            Products = new List<Product>();
        }
    }

    // Customers
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class Customer
    {

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string CustomerId { get; set; } // Customer ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string CompanyName { get; set; } // Company Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ContactName { get; set; } // Contact Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ContactTitle { get; set; } // Contact Title

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Address { get; set; } // Address

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string City { get; set; } // City

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Region { get; set; } // Region

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string PostalCode { get; set; } // Postal Code

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Country { get; set; } // Country

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Phone { get; set; } // Phone

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Fax { get; set; } // Fax

        // Reverse navigation
        public virtual ICollection<Order> Orders { get; set; } // Orders.Orders_FK00
        
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public Customer()
        {
            Orders = new List<Order>();
        }
    }

    // Employees
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class Employee
    {

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int EmployeeId { get; set; } // Employee ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string LastName { get; set; } // Last Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string FirstName { get; set; } // First Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Title { get; set; } // Title

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public DateTime? BirthDate { get; set; } // Birth Date

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public DateTime? HireDate { get; set; } // Hire Date

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Address { get; set; } // Address

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string City { get; set; } // City

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Region { get; set; } // Region

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string PostalCode { get; set; } // Postal Code

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Country { get; set; } // Country

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string HomePhone { get; set; } // Home Phone

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Extension { get; set; } // Extension

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public byte[] Photo { get; set; } // Photo

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Notes { get; set; } // Notes

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int? ReportsTo { get; set; } // Reports To

        // Reverse navigation
        public virtual ICollection<Order> Orders { get; set; } // Orders.Orders_FK02
        
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public Employee()
        {
            Orders = new List<Order>();
        }
    }

    // Orders
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class Order
    {

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int OrderId { get; set; } // Order ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string CustomerId { get; set; } // Customer ID

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int? EmployeeId { get; set; } // Employee ID

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ShipName { get; set; } // Ship Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ShipAddress { get; set; } // Ship Address

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ShipCity { get; set; } // Ship City

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ShipRegion { get; set; } // Ship Region

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ShipPostalCode { get; set; } // Ship Postal Code

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ShipCountry { get; set; } // Ship Country

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int? ShipVia { get; set; } // Ship Via

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public DateTime? OrderDate { get; set; } // Order Date

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public DateTime? RequiredDate { get; set; } // Required Date

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public DateTime? ShippedDate { get; set; } // Shipped Date

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public decimal? Freight { get; set; } // Freight

        // Reverse navigation
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Customer Customer { get; set; } // Orders_FK00
        public virtual Employee Employee { get; set; } // Orders_FK02
        public virtual Shipper Shipper { get; set; } // Orders_FK01
        
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }

    // Order Details
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class OrderDetail
    {

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int OrderId { get; set; } // Order ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int ProductId { get; set; } // Product ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public decimal UnitPrice { get; set; } // Unit Price

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public short Quantity { get; set; } // Quantity

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public float Discount { get; set; } // Discount

        // Foreign keys
        public virtual Order Order { get; set; } // OrderDetails_FK01
        public virtual Product Product { get; set; } // OrderDetails_FK00
    }

    // Products
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class Product
    {

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int ProductId { get; set; } // Product ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int? SupplierId { get; set; } // Supplier ID

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int? CategoryId { get; set; } // Category ID

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ProductName { get; set; } // Product Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string EnglishName { get; set; } // English Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string QuantityPerUnit { get; set; } // Quantity Per Unit

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public decimal? UnitPrice { get; set; } // Unit Price

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public short? UnitsInStock { get; set; } // Units In Stock

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public short? UnitsOnOrder { get; set; } // Units On Order

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public short? ReorderLevel { get; set; } // Reorder Level

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public bool Discontinued { get; set; } // Discontinued

        // Reverse navigation
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Category Category { get; set; } // Products_FK01
        public virtual Supplier Supplier { get; set; } // Products_FK00
        
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public Product()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }

    // Shippers
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class Shipper
    {

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int ShipperId { get; set; } // Shipper ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string CompanyName { get; set; } // Company Name

        // Reverse navigation
        public virtual ICollection<Order> Orders { get; set; } // Orders.Orders_FK01
        
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public Shipper()
        {
            Orders = new List<Order>();
        }
    }

    // Suppliers
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
    public class Supplier
    {

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public int SupplierId { get; set; } // Supplier ID (Primary key)

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string CompanyName { get; set; } // Company Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ContactName { get; set; } // Contact Name

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string ContactTitle { get; set; } // Contact Title

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Address { get; set; } // Address

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string City { get; set; } // City

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Region { get; set; } // Region

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string PostalCode { get; set; } // Postal Code

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Country { get; set; } // Country

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Phone { get; set; } // Phone

        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public string Fax { get; set; } // Fax

        // Reverse navigation
        public virtual ICollection<Product> Products { get; set; } // Products.Products_FK00
        
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public Supplier()
        {
            Products = new List<Product>();
        }
    }


    // ************************************************************************
    // POCO Configuration

    // Categories
    internal class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public CategoryConfiguration(string schema = "")
        {
            ToTable("Categories");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryId).HasColumnName("Category ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CategoryName).HasColumnName("Category Name").IsRequired().HasMaxLength(15);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(536870911);
            Property(x => x.Picture).HasColumnName("Picture").IsOptional().HasMaxLength(1073741823);
        }
    }

    // Customers
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public CustomerConfiguration(string schema = "")
        {
            ToTable("Customers");
            HasKey(x => x.CustomerId);

            Property(x => x.CustomerId).HasColumnName("Customer ID").IsRequired().HasMaxLength(5).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CompanyName).HasColumnName("Company Name").IsRequired().HasMaxLength(40);
            Property(x => x.ContactName).HasColumnName("Contact Name").IsOptional().HasMaxLength(30);
            Property(x => x.ContactTitle).HasColumnName("Contact Title").IsOptional().HasMaxLength(30);
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("Postal Code").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            Property(x => x.Phone).HasColumnName("Phone").IsOptional().HasMaxLength(24);
            Property(x => x.Fax).HasColumnName("Fax").IsOptional().HasMaxLength(24);
        }
    }

    // Employees
    internal class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public EmployeeConfiguration(string schema = "")
        {
            ToTable("Employees");
            HasKey(x => x.EmployeeId);

            Property(x => x.EmployeeId).HasColumnName("Employee ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.LastName).HasColumnName("Last Name").IsRequired().HasMaxLength(20);
            Property(x => x.FirstName).HasColumnName("First Name").IsRequired().HasMaxLength(10);
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasMaxLength(30);
            Property(x => x.BirthDate).HasColumnName("Birth Date").IsOptional();
            Property(x => x.HireDate).HasColumnName("Hire Date").IsOptional();
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("Postal Code").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            Property(x => x.HomePhone).HasColumnName("Home Phone").IsOptional().HasMaxLength(24);
            Property(x => x.Extension).HasColumnName("Extension").IsOptional().HasMaxLength(4);
            Property(x => x.Photo).HasColumnName("Photo").IsOptional().HasMaxLength(1073741823);
            Property(x => x.Notes).HasColumnName("Notes").IsOptional().HasMaxLength(536870911);
            Property(x => x.ReportsTo).HasColumnName("Reports To").IsOptional();
        }
    }

    // Orders
    internal class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public OrderConfiguration(string schema = "")
        {
            ToTable("Orders");
            HasKey(x => x.OrderId);

            Property(x => x.OrderId).HasColumnName("Order ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CustomerId).HasColumnName("Customer ID").IsRequired().HasMaxLength(5);
            Property(x => x.EmployeeId).HasColumnName("Employee ID").IsOptional();
            Property(x => x.ShipName).HasColumnName("Ship Name").IsOptional().HasMaxLength(40);
            Property(x => x.ShipAddress).HasColumnName("Ship Address").IsOptional().HasMaxLength(60);
            Property(x => x.ShipCity).HasColumnName("Ship City").IsOptional().HasMaxLength(15);
            Property(x => x.ShipRegion).HasColumnName("Ship Region").IsOptional().HasMaxLength(15);
            Property(x => x.ShipPostalCode).HasColumnName("Ship Postal Code").IsOptional().HasMaxLength(10);
            Property(x => x.ShipCountry).HasColumnName("Ship Country").IsOptional().HasMaxLength(15);
            Property(x => x.ShipVia).HasColumnName("Ship Via").IsOptional();
            Property(x => x.OrderDate).HasColumnName("Order Date").IsOptional();
            Property(x => x.RequiredDate).HasColumnName("Required Date").IsOptional();
            Property(x => x.ShippedDate).HasColumnName("Shipped Date").IsOptional();
            Property(x => x.Freight).HasColumnName("Freight").IsOptional().HasPrecision(19,4);

            // Foreign keys
            HasRequired(a => a.Customer).WithMany(b => b.Orders).HasForeignKey(c => c.CustomerId); // Orders_FK00
            HasOptional(a => a.Employee).WithMany(b => b.Orders).HasForeignKey(c => c.EmployeeId); // Orders_FK02
            HasOptional(a => a.Shipper).WithMany(b => b.Orders).HasForeignKey(c => c.ShipVia); // Orders_FK01
        }
    }

    // Order Details
    internal class OrderDetailConfiguration : EntityTypeConfiguration<OrderDetail>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public OrderDetailConfiguration(string schema = "")
        {
            ToTable("Order Details");
            HasKey(x => new { x.OrderId, x.ProductId });

            Property(x => x.OrderId).HasColumnName("Order ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("Product ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UnitPrice).HasColumnName("Unit Price").IsRequired().HasPrecision(19,4);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired();
            Property(x => x.Discount).HasColumnName("Discount").IsRequired();

            // Foreign keys
            HasRequired(a => a.Order).WithMany(b => b.OrderDetails).HasForeignKey(c => c.OrderId); // OrderDetails_FK01
            HasRequired(a => a.Product).WithMany(b => b.OrderDetails).HasForeignKey(c => c.ProductId); // OrderDetails_FK00
        }
    }

    // Products
    internal class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public ProductConfiguration(string schema = "")
        {
            ToTable("Products");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("Product ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.SupplierId).HasColumnName("Supplier ID").IsOptional();
            Property(x => x.CategoryId).HasColumnName("Category ID").IsOptional();
            Property(x => x.ProductName).HasColumnName("Product Name").IsRequired().HasMaxLength(40);
            Property(x => x.EnglishName).HasColumnName("English Name").IsOptional().HasMaxLength(40);
            Property(x => x.QuantityPerUnit).HasColumnName("Quantity Per Unit").IsOptional().HasMaxLength(20);
            Property(x => x.UnitPrice).HasColumnName("Unit Price").IsOptional().HasPrecision(19,4);
            Property(x => x.UnitsInStock).HasColumnName("Units In Stock").IsOptional();
            Property(x => x.UnitsOnOrder).HasColumnName("Units On Order").IsOptional();
            Property(x => x.ReorderLevel).HasColumnName("Reorder Level").IsOptional();
            Property(x => x.Discontinued).HasColumnName("Discontinued").IsRequired();

            // Foreign keys
            HasOptional(a => a.Supplier).WithMany(b => b.Products).HasForeignKey(c => c.SupplierId); // Products_FK00
            HasOptional(a => a.Category).WithMany(b => b.Products).HasForeignKey(c => c.CategoryId); // Products_FK01
        }
    }

    // Shippers
    internal class ShipperConfiguration : EntityTypeConfiguration<Shipper>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public ShipperConfiguration(string schema = "")
        {
            ToTable("Shippers");
            HasKey(x => x.ShipperId);

            Property(x => x.ShipperId).HasColumnName("Shipper ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyName).HasColumnName("Company Name").IsRequired().HasMaxLength(40);
        }
    }

    // Suppliers
    internal class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "1.0.0.0")]
        public SupplierConfiguration(string schema = "")
        {
            ToTable("Suppliers");
            HasKey(x => x.SupplierId);

            Property(x => x.SupplierId).HasColumnName("Supplier ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CompanyName).HasColumnName("Company Name").IsRequired().HasMaxLength(40);
            Property(x => x.ContactName).HasColumnName("Contact Name").IsOptional().HasMaxLength(30);
            Property(x => x.ContactTitle).HasColumnName("Contact Title").IsOptional().HasMaxLength(30);
            Property(x => x.Address).HasColumnName("Address").IsOptional().HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsOptional().HasMaxLength(15);
            Property(x => x.Region).HasColumnName("Region").IsOptional().HasMaxLength(15);
            Property(x => x.PostalCode).HasColumnName("Postal Code").IsOptional().HasMaxLength(10);
            Property(x => x.Country).HasColumnName("Country").IsOptional().HasMaxLength(15);
            Property(x => x.Phone).HasColumnName("Phone").IsOptional().HasMaxLength(24);
            Property(x => x.Fax).HasColumnName("Fax").IsOptional().HasMaxLength(24);
        }
    }

}

