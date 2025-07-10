using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ClientProgressionUpdateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _LocalUserChangedQuery;
    EntityQuery _LockProgressionEvents;
    EntityQuery _UnlockProgressionEvents;
    EntityQuery _InitialProgressionEvents;
    EntityQuery __query_49836642_0;
    EntityQuery __query_49836642_1;
    EntityQuery __query_49836642_2;
    EntityQuery __query_49836642_3;
    EntityQuery __query_49836642_4;
    EntityQuery __query_49836642_5;
    EntityQuery __query_49836642_6;
    
    // unmanaged system, skipped generating example queries

}
