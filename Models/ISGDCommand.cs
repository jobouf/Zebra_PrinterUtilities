// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Zebra.Sdk.Comm;

namespace Zebra_LabelProfile.Models
{
    public interface ISGDCommand
    {
        string Setting { get; set; }
        string? Result { get; }
        string? Execute(Connection connection);
    }
}
