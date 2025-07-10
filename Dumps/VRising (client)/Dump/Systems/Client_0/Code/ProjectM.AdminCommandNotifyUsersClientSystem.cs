using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AdminCommandNotifyUsersClientSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_352125719_0;
    EntityQuery __query_352125719_1;
    
    // unmanaged system, skipped generating example queries

}
