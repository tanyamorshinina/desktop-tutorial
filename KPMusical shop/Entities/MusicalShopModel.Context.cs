﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KPMusical_shop.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Musical_magazinEntities : DbContext
    {
        public Musical_magazinEntities()
            : base("name=Musical_magazinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Doljnosti> Doljnostis { get; set; }
        public virtual DbSet<Korzina> Korzinas { get; set; }
        public virtual DbSet<Korzina_pokupateley> Korzina_pokupateley { get; set; }
        public virtual DbSet<Pokupateli> Pokupatelis { get; set; }
        public virtual DbSet<Pridaji> Pridajis { get; set; }
        public virtual DbSet<Sotrudniki> Sotrudnikis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tovari> Tovaris { get; set; }
    }
}
