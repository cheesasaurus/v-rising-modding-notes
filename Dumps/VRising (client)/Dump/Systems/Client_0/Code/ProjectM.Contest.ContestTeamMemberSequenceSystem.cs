using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestTeamMemberSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ContestTeamChangedQuery;
    EntityQuery __query_647478889_0;
    EntityQuery __query_647478889_1;
    EntityQuery __query_647478889_2;
    
    // unmanaged system, skipped generating example queries

}
