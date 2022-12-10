using Unit06.Game.Casting;
using Unit06.Game.Services;
using System.Collections.Generic;


namespace Unit06.Game.Scripting
{
    public class DrawBackGroundAction : Action
    {
        private VideoService _videoService;
        
        public DrawBackGroundAction(VideoService videoService)
        {
            this._videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            List<Actor> rackets = cast.GetActors(Constants.BACKGROUND_GROUP);
            foreach (Actor racketn in rackets){
                Background racket = (Background)racketn;
                Body body = racket.GetBody();

                if (racket.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    _videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
                }
            
                Animation animation = racket.GetAnimation();
                Image image = animation.NextImage();
                Point position = body.GetPosition();
                _videoService.DrawImage(image, position);
            
        }}
    }
}