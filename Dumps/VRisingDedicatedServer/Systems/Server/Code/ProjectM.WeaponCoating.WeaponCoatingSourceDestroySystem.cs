using Unity.Entities;

namespace ProjectM.WeaponCoating;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WeaponCoatingSourceDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1145599414_0;
    EntityQuery __query_1145599414_1;
    
    // unmanaged system, skipped generating example queries

}
