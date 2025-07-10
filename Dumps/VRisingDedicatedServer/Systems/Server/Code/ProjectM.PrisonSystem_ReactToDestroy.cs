using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PrisonSystem_ReactToDestroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query0;
    EntityQuery _Query1;
    EntityQuery __query_1527516166_0;
    EntityQuery __query_1527516166_1;
    EntityQuery __query_1527516166_2;
    
    // unmanaged system, skipped generating example queries

}
