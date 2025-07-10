using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyPhysicsShapeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1176601398_0;
    EntityQuery __query_1176601398_1;
    
    // unmanaged system, skipped generating example queries

}
