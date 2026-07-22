// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;

namespace LabelUtilities.Core.Models
{
    public enum SGDType
    {
        SET = 0,
        GET = 1,
        DO = 2
    }

    internal class SGDCommand : ISGDCommand
    {
        public SGDType CommandType { get; set; }
        public string Setting { get; set; }
        public string? Value { get; set; }
        public string? Result { get; private set; }
        public SGDCommand() { }
        public SGDCommand(SGDType commandtype, string setting, string? value = null, string? result = null)
        {
            CommandType = commandtype;
            Setting = setting;
            Value = value;
            Result = result;
        }

        public string? Execute(Connection connection)
        {
            switch (CommandType)
            {
                case SGDType.SET:
                    SGD.SET(Setting, Value, connection);
                    return null;
                case SGDType.GET:
                    Result = SGD.GET(Setting, connection);
                    return Result;
                case SGDType.DO:
                    Result = SGD.DO(Setting, Value, connection);
                    return Result;
                default:
                    return null;

            }
        }
    }
}
