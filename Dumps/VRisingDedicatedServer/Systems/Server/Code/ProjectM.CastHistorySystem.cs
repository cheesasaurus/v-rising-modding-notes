using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastHistorySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2067722663_0;
    EntityQuery __query_2067722663_1;
    EntityQuery __query_2067722663_2;
    EntityQuery __query_2067722663_3;
    
    // unmanaged system, skipped generating example queries

}
