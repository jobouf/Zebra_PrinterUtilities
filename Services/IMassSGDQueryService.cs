using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zebra.Sdk.Comm;

namespace Zebra_LabelProfile.Services
{
    public interface IMassSGDQueryService
    {
        public interface ISGDQuery
        {
            String Command { get; set; }
            String? Result { get; set; }
        }

        List<ISGDQuery> InitializeQueryList(Connection connection);
    }
}
