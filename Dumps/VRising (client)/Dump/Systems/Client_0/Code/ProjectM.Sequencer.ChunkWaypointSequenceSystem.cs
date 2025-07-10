using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ChunkWaypointSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1647349992_0;
    EntityQuery __query_1647349992_1;
    EntityQuery __query_1647349992_2;
    
    // unmanaged system, skipped generating example queries

}
