using Entitas;
using System.Collections.Generic;
    public sealed class LogHealthSystem : ReactiveSystem<GameEntity>
{
    public LogHealthSystem(Contexts contexts) : base(contexts.game) { }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Health);
    }
     protected override bool Filter(GameEntity entity)
    {
        return entity.hasHealth;
    }
   
    protected override void Execute(List<GameEntity> entities) { 
    foreach (var e in entities)
        {
            var health = e.health.value;
            UnityEngine.Debug.Log("health: " + health);
        }
    }

   
}
