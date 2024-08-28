// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.FSharp.FunctionalTests

open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.TestModels.Northwind

[<CLIMutable>]
type CustomerFSharp = {
    CustomerID: string;
    Address: string option;
}    

type NorthwindFSharpSqlServerContext(options) =
    inherit NorthwindSqlServerContext(options)

    member self.CustomerFSharp = self.Set<CustomerFSharp>()

    override _.OnModelCreating builder =
        do builder.Entity<CustomerFSharp>().ToTable("Customers") |> ignore