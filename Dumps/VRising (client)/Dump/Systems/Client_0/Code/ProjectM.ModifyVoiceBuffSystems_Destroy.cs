using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyVoiceBuffSystems_Destroy : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_1703158878_0;
    EntityQuery __query_1703158878_1;
    
    // unmanaged system, skipped generating example queries

}
