// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.FSharp.FunctionalTests

open System.ComponentModel.DataAnnotations
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.TestModels.Northwind
open Microsoft.EntityFrameworkCore.Metadata.Builders

[<CLIMutable>]
type CustomerFSharp = {

    [<Required>]
    CustomerID: string
    
    //Address: string option
}

type NorthwindFSharpSqlServerContext(options) =
    inherit NorthwindSqlServerContext(options)

    let configure (builder: EntityTypeBuilder<CustomerFSharp>) =
        do builder.ToView("Customers") |> ignore
        do builder.HasKey(fun e -> e.CustomerID :> obj) |> ignore

    override _.OnModelCreating builder =
        do base.OnModelCreating(builder)
        do builder.Entity<CustomerFSharp>(configure) |> ignore