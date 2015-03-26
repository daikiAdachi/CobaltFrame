﻿using CobaltFrame.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobaltFrame.Object
{
    public interface IGameObject
    {
        void Initialize();
        void LoadObject();
        void UnloadObject();
        void Update(ObjectFrameContext frameContext);
        
        
    }
}
