using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup))]
[UpdateBefore(typeof(ProjectM.AggroSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AlertSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UpdateRemoveQuery;
    EntityQuery _UpdateAggregateRadiiQuery;
    EntityQuery _UpdateAddNewFromVicinityQuery;
    EntityQuery _UpdateCalculateAlertValuesQuery;
    EntityQuery _UpdateSortAndSetTargetQuery;
    EntityQuery __query_1764159321_0;
    EntityQuery __query_1764159321_1;
    EntityQuery __query_1764159321_2;
    EntityQuery __query_1764159321_3;
    EntityQuery __query_1764159321_4;
    EntityQuery __query_1764159321_5;
    EntityQuery __query_1764159321_6;
    
    // unmanaged system, skipped generating example queries

}
