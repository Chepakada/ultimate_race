using Unit06.Game.Casting;
using System.Collections.Generic;
namespace Unit06.Game.Scripting

{
    public class MoveBrickAction : Action
    {
        public MoveBrickAction()
        {
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            //Brick ball = (Brick)cast.GetFirstActor(Constants.BRICK_GROUP);
            List<Actor> balls = cast.GetActors(Constants.BRICK_GROUP);
            foreach (Actor balln in balls){
                Brick ball = (Brick)balln;
                Body body = ball.GetBody();
                Point position = body.GetPosition();
                Point velocity = body.GetVelocity();
                if (position.GetY()< Constants.Background_Height){
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