using Unity.Entities;

namespace Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct VampireAttributeSystem_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_2123997395_0;
    EntityQuery __query_2123997395_1;
    
    // unmanaged system, skipped generating example queries

}
