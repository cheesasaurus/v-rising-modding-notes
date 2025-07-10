using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ImmaterialDuringContestSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ImmaterialChangedQuery;
    EntityQuery __query_2009269802_0;
    EntityQuery __query_2009269802_1;
    
    // unmanaged system, skipped generating example queries

}
