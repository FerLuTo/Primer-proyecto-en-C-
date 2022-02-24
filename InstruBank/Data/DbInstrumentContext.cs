using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InstruBank.Models;

namespace InstruBank.Data
{
    public class DbInstrumentContext:DbContext
    {
        public DbInstrumentContext(DbContextOptions<DbInstrumentContext> options) : base(options)
        { }

        public DbSet<Instrument> Instruments { get; set; }
    }
}
