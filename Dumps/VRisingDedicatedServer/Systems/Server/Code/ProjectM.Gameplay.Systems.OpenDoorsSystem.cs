using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct OpenDoorsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_780175475_0;
    EntityQuery __query_780175475_1;
    EntityQuery __query_780175475_2;
    EntityQuery __query_780175475_3;
    
    // unmanaged system, skipped generating example queries

}
