using Du.DynamoSolidWorks.Commands;
using Du.SolidWorks.Attributes;

namespace Du.DynamoSolidWorks
{
    public enum TabType
    {
        Box
    }
    public class AssemblyCommandsConfig
    {
        [BoxOrder(Order = 0)]
        [CommandCollection(typeof(DynamoCommand))]
        public TabType DynamoCommand { get; set; } = TabType.Box;
    }

    public class PartCommandsConfig
    {
        [BoxOrder(Order = 0)]
        [CommandCollection(typeof(DynamoCommand))]
        public TabType DynamoCommand { get; set; } = TabType.Box;
    }

    public class DrawingCommandsConfig
    {
        [BoxOrder(Order = 0)]
        [CommandCollection(typeof(DynamoCommand))]
        public TabType DynamoCommand { get; set; } = TabType.Box;
    }
}
