using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;
using static Zebra_LabelProfile.MainView;
using static Zebra_LabelProfile.Services.IMassSGDQueryService;

namespace Zebra_LabelProfile.Services
{
    internal class MassSGDQueryService : IMassSGDQueryService
    {


        internal class SGDQuery : ISGDQuery
        {
            public string Command { get; set; }
            public string? Result { get; set; }
        }

        private List<ISGDQuery> SGDQueryList = new();
        public MassSGDQueryService()
        {

        }

        public List<ISGDQuery> InitializeQueryList(Connection connection)
        {
            if (!connection.Connected)
            {
                throw new ConnectionException("SGDQuery: Could not open connection");
            }
            else
            {
                SGDQueryList?.Clear();
                SGDQueryList.AddRange(
                    (new SGDQuery { Command = "device.unique_id" }),
                    (new SGDQuery { Command = "device.sensor_profile" }),
                    (new SGDQuery { Command = "device.sensor_select" }),
                    (new SGDQuery { Command = "sensor.gap.thold" }),
                    (new SGDQuery { Command = "sensor.gap.offset" }),
                    (new SGDQuery { Command = "sensor.gap.gain" }),
                    (new SGDQuery { Command = "sensor.gap.brightness" }),
                    (new SGDQuery { Command = "sensor.gap.curr" }),
                    (new SGDQuery { Command = "sensor.front_gap.thold" }),
                    (new SGDQuery { Command = "sensor.front_gap.offset" }),
                    (new SGDQuery { Command = "sensor.front_gap.gain" }),
                    (new SGDQuery { Command = "sensor.front_gap.brightness" }),
                    (new SGDQuery { Command = "sensor.front_gap.curr" }),
                    (new SGDQuery { Command = "sensor.front_gap.ppr_out_thold" })
                );

                for (int i = 0; i < SGDQueryList.Count; i++)
                {
                    SGDQueryList[i].Result = SGD.GET(SGDQueryList[i].Command, connection);
                }
                return SGDQueryList;
            }
        }
    }
}
