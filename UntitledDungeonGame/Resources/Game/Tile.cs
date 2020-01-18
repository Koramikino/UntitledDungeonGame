﻿using Bunni.Resources.Components;
using Bunni.Resources.Modules;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UntitledDungeonGame.Resources.Game
{
    class Tile : Entity
    {
        public DTypes.TileVersions TileVersion { get; set; }

        public Tile(Texture2D tex)
        {
            PositionVector posEnt = new PositionVector();
            Render rendEnt = new Render(tex);
            AddComponent(posEnt);
            AddComponent(rendEnt);
        }

    }
}
