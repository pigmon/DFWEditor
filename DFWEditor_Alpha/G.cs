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
        public static bool bAreaBrush;                  // 是否鼠标拖框画tile
        public static bool bGrid;                       // 是否画网格
        public static int tileSize = 64;
        public static PopZone selectedTexture;          // 当前正操作的贴图
        public static Image selectedTile;               // 当前选中的tile （在左侧的贴图选择部分）
        public static bool bRepaintTextures;
        public static bool bRepaintMainPanel;
        public static bool bRepaintAll;
        public static Map currentMap;                   // 当前编辑的地图
        public static int TilesPerLineInTexture;        // 左侧的贴图选择部分每行最多能显示多少个块
        public static int PopZoneWidth;
    }
}
