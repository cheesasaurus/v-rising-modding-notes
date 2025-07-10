using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CurveCollectionUpdaterSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _NewCurvesQuery;
    EntityQuery __query_1746688731_0;
    EntityQuery __query_1746688731_1;
    
    // unmanaged system, skipped generating example queries

}
