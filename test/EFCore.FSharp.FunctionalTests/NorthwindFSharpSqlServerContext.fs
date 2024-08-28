// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.FSharp.FunctionalTests

open System.ComponentModel.DataAnnotations
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.TestModels.Northwind

type CustomerFSharp() =
    inherit Customer()

    [<MaxLength(60)>]
    member _.Address: string option = None

type NorthwindFSharpSqlServerContext(options) =
    inherit NorthwindSqlServerContext(options)

    member self.CustomerFSharp = self.Set<CustomerFSharp>()

    override _.OnModelCreating builder =
        do base.OnModelCreating(builder)
        do builder.Entity<CustomerFSharp>(fun b ->
            do b.ToTable("Customers") |> ignore
            //do b.HasKey(fun e -> e.CustomerID :> obj) |> ignore
            //do b.Property(fun e -> e.CustomerID).HasColumnName("CustomerID") |> ignore
            //do b.HasOne<Customer>().WithOne().HasForeignKey(fun e -> e.CustomerID :> obj).IsRequired() |> ignore
            )
            |> ignore
        //do builder.Entity<CustomerFSharp>().HasKey(fun e -> e.CustomerID :> obj) |> ignore