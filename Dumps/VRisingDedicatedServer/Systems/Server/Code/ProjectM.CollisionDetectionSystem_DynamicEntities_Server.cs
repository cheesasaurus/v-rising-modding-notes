using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CollisionDetectionSystem_DynamicEntities_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DynamicQuery;
    EntityQuery __query_998138853_0;
    
    // unmanaged system, skipped generating example queries

}
