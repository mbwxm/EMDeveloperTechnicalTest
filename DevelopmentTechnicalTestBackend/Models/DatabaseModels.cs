using Microsoft.EntityFrameworkCore;
using System;

namespace DevelopmentTechnicalTestBackend.Models
{
    public class PaymentsContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }

        public string DBPath { get; private set; }

        public PaymentsContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DBPath = $"{path}{System.IO.Path.DirectorySeparatorChar}Payments.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DBPath}");
    }

    public class Payment
    {
        public long ID { get; set; }

        public string To { get; set; }

        public string From { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateToSend { get; set; }
    }

    public class PaymentService
    {
        public Payment Create(Payment payment)
        {
            using (var context = new PaymentsContext())
            {
                context.Payments.Add(payment);
                context.SaveChanges();
            }
            return payment;
        }
    }
}
