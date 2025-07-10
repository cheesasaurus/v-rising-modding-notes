using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PlayerCombatBuffSystem_InitialApplication_Aggro : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_928948735_0;
    EntityQuery __query_928948735_1;
    
    // unmanaged system, skipped generating example queries

}
