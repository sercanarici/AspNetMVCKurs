namespace Alcom.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Alcom.DAL.AlcomContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Alcom.DAL.AlcomContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Kategori.AddOrUpdate(new MODEL.Kategori { Id = 1, Adi = "Elektronik", KayitTarihi = DateTime.Now, SilindiMi = false });
            context.Kategori.AddOrUpdate(new MODEL.Kategori { Id = 2, Adi = "Mobilya", KayitTarihi = DateTime.Now, SilindiMi = false });
            context.Rol.AddOrUpdate(new MODEL.Rol { KayitTarihi = DateTime.Now, Aciklama = "Son Kullanici", Id = 1 });
            context.SaveChanges();
        }
    }
}
