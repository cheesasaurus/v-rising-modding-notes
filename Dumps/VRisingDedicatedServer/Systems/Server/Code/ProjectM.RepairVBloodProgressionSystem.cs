using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RepairVBloodProgressionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_137580429_0;
    EntityQuery __query_137580429_1;
    
    // unmanaged system, skipped generating example queries

}
