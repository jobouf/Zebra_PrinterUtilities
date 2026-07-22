// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Zebra.Sdk.Comm;
using Zebra_LabelProfile.Models;

namespace Zebra_LabelProfile.Services
{
    public interface ISGDCommandListService
    {
        List<ISGDCommand> SGDCommandList { get; }
        int ListProgress { get; }
        int ListLength { get { return SGDCommandList.Count; } }
        public List<ISGDCommand> InitDefaultCommandList();
        public List<ISGDCommand> ExecuteCommandList(Connection connection, IProgress<int> progress);
    }
}
