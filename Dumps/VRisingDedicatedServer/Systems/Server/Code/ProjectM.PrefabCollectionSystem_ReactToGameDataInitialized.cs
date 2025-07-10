using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup), OrderFirst = true)]
[UpdateAfter(typeof(ProjectM.PrefabCollectionSystem))]
public struct PrefabCollectionSystem_ReactToGameDataInitialized : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_216177646_0;
    
    // unmanaged system, skipped generating example queries

}
