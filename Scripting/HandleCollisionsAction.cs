using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
{
    public class HandleCollisionsActions : Action
    {
        AudioService audioService = new AudioService();
        PhysicsService physicsService = new PhysicsService();
        public HandleCollisionsActions()
        {

        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor orb = cast["balls"][0];
            Actor paddle = cast["paddle"][0];
            

            bool collision = physicsService.IsCollision(orb, paddle);

            if (collision)
            {
                int x = orb.GetX();
                int y = orb.GetY();

                int dx = orb.GetVelocity().GetX();
                int dy = orb.GetVelocity().GetY();

                dy = -dy;                
                orb.SetVelocity(new Point(dx, dy));

                audioService.PlaySound(Constants.SOUND_BOUNCE);
            }
        }
    }
}