using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
public struct RemoveDestroyedEntityFromMicroPOISystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1615169496_0;
    EntityQuery __query_1615169496_1;
    EntityQuery __query_1615169496_2;
    EntityQuery __query_1615169496_3;
    EntityQuery __query_1615169496_4;
    
    // unmanaged system, skipped generating example queries

}
