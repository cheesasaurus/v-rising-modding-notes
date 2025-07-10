using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
public struct StoreDestroyedEntitiesSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _PrevNewDestroyedQuery;
    EntityQuery _DestroyQuery;
    EntityQuery _UserQuery;
    EntityQuery __query_1980755622_0;
    EntityQuery __query_1980755622_1;
    EntityQuery __query_1980755622_2;
    EntityQuery __query_1980755622_3;
    EntityQuery __query_1980755622_4;
    EntityQuery __query_1980755622_5;
    EntityQuery __query_1980755622_6;
    
    // unmanaged system, skipped generating example queries

}
