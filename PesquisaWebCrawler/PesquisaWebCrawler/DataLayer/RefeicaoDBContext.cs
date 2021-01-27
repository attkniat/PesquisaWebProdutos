using Microsoft.EntityFrameworkCore;
using PesquisaWebCrawler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaWebCrawler.DataLayer
{
    public class RefeicaoDBContext : DbContext
    {
        public RefeicaoDBContext(DbContextOptions<RefeicaoDBContext> options) : base(options) { }
        public DbSet<Refeição> Refeicao { get; set; }
    }
}