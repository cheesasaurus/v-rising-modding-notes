using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
public struct SingletonPrefabInstantiationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _RegisterPrefabQuery;
    EntityQuery __query_921450291_0;
    
    // unmanaged system, skipped generating example queries

}
