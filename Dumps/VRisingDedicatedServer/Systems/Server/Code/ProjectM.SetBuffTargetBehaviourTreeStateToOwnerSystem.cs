using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SetBuffTargetBehaviourTreeStateToOwnerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query0;
    EntityQuery _Query1;
    EntityQuery __query_238017992_0;
    EntityQuery __query_238017992_1;
    EntityQuery __query_238017992_2;
    
    // unmanaged system, skipped generating example queries

}
