using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CHTPZ_TEST_TASK_App.EF
{
    class chtpzDBcontext : DbContext
    {
        public virtual DbSet<FIRM> FIRMs { get; set; }
        public virtual DbSet<CITY> CITYs { get; set; }
        public virtual DbSet<DOCUMENT> DOCUMENTs { get; set; }
        public chtpzDBcontext() : base("name=CHTPZ_TEST_TASK_App.Properties.Settings.SqlConnectionRoot")
        {
            if (Database.Exists())
            {
                Database.SetInitializer<chtpzDBcontext>(new MigrationInitializer());
            }
            else
            {
                Database.SetInitializer<chtpzDBcontext>(new CreateIfNotExistInitializer());
            }
            //Database.SetInitializer<chtpzDBcontext>(new MigrationInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new FIRM_Configuration());
            base.OnModelCreating(modelBuilder);
        }



        class MigrationInitializer : MigrateDatabaseToLatestVersion<CHTPZ_TEST_TASK_App.EF.chtpzDBcontext, CHTPZ_TEST_TASK_App.Migrations.Configuration>
        {

        }

        class CreateIfNotExistInitializer : CreateDatabaseIfNotExists<CHTPZ_TEST_TASK_App.EF.chtpzDBcontext>
        {
            protected override void Seed(chtpzDBcontext context)
            {
                //Генерируем тестовые данные
                #region Города
                context.CITYs.Add(new CITY("Челябинск"));
                context.CITYs.Add(new CITY("Москва"));
                context.CITYs.Add(new CITY("Екатеринбург"));
                context.CITYs.Add(new CITY("Тюмень"));
                context.CITYs.Add(new CITY("Уфа"));
                #endregion

                #region Фирмы и случайные города юрид. и почтовых адресов 
                var countCITY = context.CITYs.Local.Count() - 1;
                for (int i = 1; i <= 23; i++)
                {
                    Random rnd = new Random();
                    int rndValue = rnd.Next(countCITY);
                    CITY curCITY_POST = context.CITYs.Local.ElementAt(rndValue);
                    rndValue = rnd.Next(countCITY);
                    CITY curCITY_JUR = context.CITYs.Local.ElementAt(rndValue);
                    context.FIRMs.Add(new FIRM { NAME = "Фирма " + i, POST_CITY = curCITY_POST, JUR_CITY = curCITY_JUR });
                }
                #endregion

                #region Генерирую Документы для наших фирм
                foreach (var item in context.FIRMs.Local)
                {//Генерирую для каждой фирмы множество документов
                    Random rnd = new Random();
                    for (int i = 1; i <= 25; i++)
                    {
                        int month = rnd.Next(1, 12);
                        int year = rnd.Next(1992, 2020);
                        int day = rnd.Next(1, DateTime.DaysInMonth(year, month));
                        int sum = rnd.Next(50000, 160000);
                        item.DOCUMENTs.Add(new DOCUMENT { DOC_DATE = new DateTime(year, month, day), SUM = sum, FIRM = item });
                    }
                }
                #endregion

                context.SaveChanges();
            }
        }
    }
}
