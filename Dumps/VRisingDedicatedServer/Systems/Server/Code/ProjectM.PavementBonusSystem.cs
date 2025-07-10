using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
public struct PavementBonusSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _TargetQuery;
    EntityQuery __query_809132419_0;
    
    // unmanaged system, skipped generating example queries

}
