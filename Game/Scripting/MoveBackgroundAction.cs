//This may not be needed. But in order to move the sides I might need to run it through this class. This resembles the MoveBallClass

//using Unit06.Game.Casting;

using Unit06.Game.Casting;

// using Unit06.Game.Services;
using System.Collections.Generic;
namespace Unit06.Game.Scripting

{

    public class MoveSidesAction : Action

    {

        public void MoveSideAction()

        {

        }



        public void Execute(Cast cast, Script script, ActionCallback callback)

        {
            
            List<Actor> sides = cast.GetActors(Constants.BACKGROUND_GROUP);
            foreach (Actor siden in sides){
                Background side = (Background)siden;
                Body body = side.GetBody();

                Point position = body.GetPosition();

                Point velocity = body.GetVelocity();

                if (position.GetY() <Constants.SCREEN_HEIGHT)
                {

                    position = position.Add(velocity);

                }

                else{

                    position = position.Reverse();

                }

                body.SetPosition(position);

            }
        }

    }

}