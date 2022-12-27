using IBBCase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBCase.Data
{
    public class IBBCaseDbContext : DbContext
    {
        //public IBBCaseDbContext(DbContextOptions options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-7JITH0C;Initial Catalog=IBBCaseDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CarPark>(entity =>
            {

                entity.HasData(new CarPark()
                {
                    CarParkId = 1,
                    _id = 1,
                    PARK_NAME ="Vali Konağı Caddesi 1", 
                    LOCATION_NAME = "Şişli Vali Konağı Caddes", 
                    PARK_TYPE_ID = "YOL ÜSTÜ", 
                    PARK_TYPE_DESC="YOL ÜSTÜ", 
                    CAPACITY_OF_PARK= 30,
                    WORKING_TIME ="08:00-19:00", 
                    COUNTY_NAME="ŞİŞLİ", 
                    LONGITUDE= 28.9879749441318992, 
                    LATITUDE= 41.0488233569154986,
                });
            });

            modelBuilder.Entity<CarPark>(entity =>
            {
                entity.HasData(new CarPark()
                {
                    CarParkId= 2,
                    _id = 2,
                    PARK_NAME ="Şakayık Sokak 1", 
                    LOCATION_NAME="Şişli Şakayık Soka", 
                    PARK_TYPE_ID="YOL ÜSTÜ",
                    PARK_TYPE_DESC="YOL ÜSTÜ",
                    CAPACITY_OF_PARK= 50, 
                    WORKING_TIME="08:00-19:00", 
                    COUNTY_NAME="ŞİŞLİ",
                    LONGITUDE= 28.9955656052444013,
                    LATITUDE= 41.0495232987717031,
                });
            });

            modelBuilder.Entity<CarPark>(entity =>
            {
                entity.HasData(new CarPark()
                {
                    CarParkId = 3,
                    _id = 3,
                    PARK_NAME = "Hüsrev Gerede Sokak 1",
                    LOCATION_NAME="Şişli Hüsrev Gerede Caddes",
                    PARK_TYPE_ID="YOL ÜSTÜ",
                    PARK_TYPE_DESC="YOL ÜSTÜ",
                    CAPACITY_OF_PARK= 50,
                    WORKING_TIME="08:00-19:00",
                    COUNTY_NAME="ŞİŞLİ",
                    LONGITUDE= 28.9949755781699992,
                    LATITUDE= 41.0483895406421979,
                });
            });
        }

        public DbSet<CarPark> CarParks { get; set; }
    }
}
