using DynamoSldWorks.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xarial.XCad.Base.Attributes;
using Xarial.XCad.UI.Commands.Attributes;
using Xarial.XCad.UI.Commands.Enums;

namespace DynamoSldWorks
{
    [Title("DynamoSldWorks")]
    [Description("Dynamo commands")]
    [Icon(typeof(Resources), nameof(Resources.logo_square_32x32))]
    public enum Commands
    {
        [Title("Dynamo")]
        [Description("Dynamo command")]
        [CommandItemInfo(WorkspaceTypes_e.All)]
        [Icon(typeof(Resources), nameof(Resources.logo_square_32x32))]
        Dynamo
    }
}
