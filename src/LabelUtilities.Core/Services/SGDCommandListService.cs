// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Zebra.Sdk.Comm;
using LabelUtilities.Core.Models;

namespace LabelUtilities.Core.Services
{
    public class SGDCommandListService : ISGDCommandListService
    {

        public List<ISGDCommand> SGDCommandList { get; private set; }
        public int ListProgress { get; private set; }
        public int ListLength { get { return SGDCommandList.Count; } }

        public List<ISGDCommand> InitDefaultCommandList()
        {
            SGDCommandList?.Clear();
            SGDCommandList.AddRange(
                new SGDCommand(SGDType.GET, "device.unique_id"),
                new SGDCommand(SGDType.GET, "device.sensor_profile"),
                new SGDCommand(SGDType.GET, "device.sensor_select"),
                new SGDCommand(SGDType.GET, "sensor.gap.thold"),
                new SGDCommand(SGDType.GET, "sensor.gap.offset"),
                new SGDCommand(SGDType.GET, "sensor.gap.gain"),
                new SGDCommand(SGDType.GET, "sensor.gap.brightness"),
                new SGDCommand(SGDType.GET, "sensor.gap.curr"),
                new SGDCommand(SGDType.GET, "sensor.front_gap.thold"),
                new SGDCommand(SGDType.GET, "sensor.front_gap.offset"),
                new SGDCommand(SGDType.GET, "sensor.front_gap.gain"),
                new SGDCommand(SGDType.GET, "sensor.front_gap.brightness"),
                new SGDCommand(SGDType.GET, "sensor.front_gap.curr")
            );
            return SGDCommandList;
        }
        public List<ISGDCommand> ExecuteCommandList(Connection connection, IProgress<int> progress)
        {
            ListProgress = 0;

            if (!connection.Connected)
            {
                throw new ConnectionException("SGDQuery: Could not open connection");
            }
            else
            {
                foreach (ISGDCommand i in SGDCommandList)
                {
                    i.Execute(connection);
                    ListProgress++;
                    progress.Report(ListProgress);
                }
                return SGDCommandList;
            }
        }
    }
}
