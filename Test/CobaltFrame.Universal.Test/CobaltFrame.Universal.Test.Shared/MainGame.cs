﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CobaltFrame;
using CobaltFrame.Screen;
using CobaltFrame.Test.Screen;
using CobaltFrame.Common;

namespace CobaltFrame.Universal.Test
{
    class MainGame:Game
    {
        GraphicsDeviceManager graphics;
        ScreenManager _screenManager;
        public MainGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            _screenManager = new ScreenManager(this,new SampleTitleScreen(new ScreenContext(this)));
            this.Components.Add(_screenManager);
        }

        protected override void Initialize()
        {
            
            base.Initialize();
        }

        
    }
}
