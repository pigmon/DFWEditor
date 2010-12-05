using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DFWEditor_Alpha
{
    public static class G
    {
        public static String Ver = "Editor Alpha  ";
        public static bool bAreaBrush;
        public static bool bGrid;
        public static int tileSize = 64;
        public static PopZone selectedTexture;
        public static Image selectedTile;
        public static bool bRepaintTextures;
        public static bool bRepaintMainPanel;
        public static Map currentMap;
    }
}
