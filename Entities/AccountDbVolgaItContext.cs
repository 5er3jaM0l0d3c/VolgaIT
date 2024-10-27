﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Entities;

public partial class AccountDbVolgaItContext : DbContext
{
    public AccountDbVolgaItContext()
    {
    }

    public AccountDbVolgaItContext(DbContextOptions<AccountDbVolgaItContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> account { get; set; }

    public virtual DbSet<Role> role { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=AccountDbVolgaIT;Username=postgres;Password=313818");

}