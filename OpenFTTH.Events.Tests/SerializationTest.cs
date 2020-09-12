using Newtonsoft.Json;
using OpenFTTH.Events.Core.Infos;
using OpenFTTH.Events.RouteNetwork;
using OpenFTTH.Events.RouteNetwork.Infos;
using System;
using Xunit;

namespace OpenFTTH.Events.Tests
{
    public class SerializationTest
    {
        [Fact]
        public void Test1()
        {
            var routeNodeAddedEvent = new RouteNodeAdded(
                eventType: typeof(RouteNodeAdded).Name,
                eventId: Guid.NewGuid(),
                eventTimestamp: DateTime.UtcNow,
                applicationName: "grumme",
                applicationInfo: "hans",
                nodeId: Guid.NewGuid(),
                geometry: "blabla",
                namingInfo: new NamingInfo("node1", "I'm a route node"),
                lifecyleInfo: new LifecycleInfo(DeploymentStateEnum.Installed, DateTime.UtcNow, DateTime.Now),
                safetyInfo: new SafetyInfo("not dangerous", "ikke farlig"),
                mappingInfo: new MappingInfo(MappingMethodEnum.Drafting, "1 m", "2 m", new DateTime(2020,01,01), "GPS"),
                routeNodeInfo: new RouteNodeInfo(RouteNodeKindEnum.BuildingAccessPoint, RouteNodeFunctionEnum.FlexPoint)
            );

            var routeNetworkEvents = new RouteNetworkEvent[] { routeNodeAddedEvent, routeNodeAddedEvent };
            var commands = new RouteNetworkCommand[] { new RouteNetworkCommand("hest", Guid.NewGuid(), routeNetworkEvents) };

            var editOp = new RouteNetworkEditOperationOccuredEvent(
                eventType: typeof(RouteNetworkEditOperationOccuredEvent).Name,
                eventId: Guid.NewGuid(),
                eventTimestamp: DateTime.UtcNow,
                applicationName: "grumme",
                applicationInfo: "hans",
                userName: "grumme hans",
                workTaskMrid: Guid.NewGuid(),
                commands: commands
            );

            var jsonSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string jsonText = JsonConvert.SerializeObject(editOp, Formatting.Indented, jsonSettings);



            var deserializedEvent = JsonConvert.DeserializeObject<RouteNetworkEditOperationOccuredEvent>(jsonText, jsonSettings);

            Assert.True(deserializedEvent.RouteNetworkCommands[0].RouteNetworkEvents[1] is RouteNodeAdded);

        }
    }
}
