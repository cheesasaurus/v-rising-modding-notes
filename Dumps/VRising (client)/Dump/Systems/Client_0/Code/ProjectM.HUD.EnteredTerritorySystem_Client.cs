using Unity.Entities;

namespace ProjectM.HUD;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.UI.MapZonePolygonUIMeshSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct EnteredTerritorySystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_141383694_0;
    EntityQuery __query_141383694_1;
    EntityQuery __query_141383694_2;
    EntityQuery __query_141383694_3;
    
    // unmanaged system, skipped generating example queries

}
