﻿using ApiWebCSharp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiWebCSharp.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) 
        { 
        
        
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
