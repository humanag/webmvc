namespace DAL.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<BlogCategory> BlogCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<ProductRelation> ProductRelations { get; set; }
        public virtual DbSet<SysParam> SysParams { get; set; }
        public virtual DbSet<SysUser> SysUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<ProductImage>()
                .Property(e => e.path)
                .IsUnicode(false);

            modelBuilder.Entity<SysParam>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<SysUser>()
                .Property(e => e.PassWD)
                .IsUnicode(false);
        }
    }
}
