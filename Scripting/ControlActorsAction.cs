using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Scripting
{
    public class ControlActorsAction : Action
    {
        InputService _inputservice;
        
        public ControlActorsAction(InputService inputService)
        {
            _inputService = inputService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Point direction = _inputservice.GetDirection();
            Actor paddle = cast["paddle"][0];


        }
    }
}