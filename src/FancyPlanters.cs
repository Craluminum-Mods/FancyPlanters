using Vintagestory.API.Common;

namespace FancyPlanters
{
  class FancyPlanters : ModSystem
  {
    public override void Start(ICoreAPI api)
    {
      base.Start(api);

      api.RegisterBlockClass("Planter2x1", typeof(BlockPlantContainer2x1));
      api.World.Logger.Event("started 'Fancy Planters'");
    }
  }
}