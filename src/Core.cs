using Vintagestory.API.Common;

[assembly: ModInfo("Fancy Planters")]

namespace FancyPlanters
{
    public class Core : ModSystem
    {
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            api.RegisterBlockClass("Planter2x1", typeof(BlockPlantContainer2x1));
            api.RegisterBlockBehaviorClass("FancyPlanters.BbName", typeof(BlockBehaviorName));
            api.World.Logger.Event("started 'Fancy Planters' mod");
        }
    }
}