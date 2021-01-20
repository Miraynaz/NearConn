using Microsoft.EntityFrameworkCore;
using NearConnEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace NearConnDAL.Concrete.EFCore
{
    public class NearConnContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-20AUB83\SQLEXPRESS02; Database= NearConn; Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    
            modelBuilder.Entity<tbl_KullaniciEtkinlik>().HasKey(k => new { k.EtkinlikId, k.KullaniciId});

        }
        public DbSet<tbl_Kullanici> tbl_Kullanici{ get; set; }
        public DbSet<tbl_Etkinlik> tbl_Etkinlik{ get; set; }

    }
}
