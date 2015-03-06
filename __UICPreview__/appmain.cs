using System;
using System.Collections.Generic;

using System.Threading;
using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Input;
using Sce.PlayStation.HighLevel.UI;

namespace Preview
{
    public class AppMain
    {
        private static GraphicsContext graphics;

        public static void Main (string[] args)
        {
            Initialize ();

            while (true) {
                SystemEvents.CheckEvents ();
                Update ();
                Render ();
            }
        }

        public static void Initialize ()
        {
            // Set up the graphics system
            graphics = new GraphicsContext ();

            // Initialize UI Toolkit
            UISystem.Initialize(graphics);

            // TODO: Create scenes and call UISystem.SetScene
			
			Preview.ZeroStep scene1 = new Preview.ZeroStep();
			Preview.FirstStep scene2 = new Preview.FirstStep();
			
			//Preview.FirstStep scene2 = new Preview.FirstStep();
			CrossFadeTransition transition1 = new CrossFadeTransition();
			
			//transition.TransitionStopped += HandleTransitionStopped;
			scene1.Transition = transition1;
            
			UISystem.SetScene(scene1);
			
			
        }

        public static void Update ()
        {
            // Query gamepad for current state
            var gamePadData = GamePad.GetData (0);
			if((gamePadData.Buttons & GamePadButtons.Cross) != 0)
			{
			Preview.FirstStep scene2 = new Preview.FirstStep();

			FlipBoardTransition transition2 = new FlipBoardTransition();
			//transition.TransitionStopped += HandleTransitionStopped;
			 scene2.Transition = transition2;

			UISystem.SetScene(scene2);
				}
			
			if((gamePadData.Buttons & GamePadButtons.Circle) != 0)
			{
				
			}
            // Query touch for current state
            List<TouchData> touchDataList = Touch.GetData (0);
			
			//if ((touchData.Status == TouchStatus.Down || touchData.Status == TouchStatus.Move) & (touchData.X > 126f) & (touchData.X < 371f) & (touchData.Y > 375f) & (touchData.Y < 509f)) {

  
			  
            // Update UI Toolkit
            UISystem.Update(touchDataList);
			
        }

         public static void Render ()
        {
            // Clear the screen
            graphics.SetClearColor (0.0f, 0.0f, 0.0f, 0.0f);
            graphics.Clear ();

            // Render UI Toolkit
            UISystem.Render ();
			
			
			

            // Present the screen
            graphics.SwapBuffers ();
        }
    }
}
