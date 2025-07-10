using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UpdateRefiningSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_263164751_0;
    EntityQuery __query_263164751_1;
    EntityQuery __query_263164751_2;
    EntityQuery __query_263164751_3;
    EntityQuery __query_263164751_4;
    
    // unmanaged system, skipped generating example queries

}
