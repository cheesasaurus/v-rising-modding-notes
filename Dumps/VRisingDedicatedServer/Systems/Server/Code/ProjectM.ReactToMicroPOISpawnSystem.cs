using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateBefore(typeof(ProjectM.UnitSpawnerReactSystem))]
public struct ReactToMicroPOISpawnSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1615169320_0;
    EntityQuery __query_1615169320_1;
    EntityQuery __query_1615169320_2;
    
    // unmanaged system, skipped generating example queries

}
