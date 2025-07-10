using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyPhysicsShapeBuffSystems_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1176601361_0;
    EntityQuery __query_1176601361_1;
    
    // unmanaged system, skipped generating example queries

}
