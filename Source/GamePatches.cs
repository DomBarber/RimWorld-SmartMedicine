﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace InventoryMedicine
{
    static class HarmonyPatches
    {
        public static void CopyListPostfix(ref List<Pawn> __result)
        {
            List<Pawn> copiedResultFFS = __result.ListFullCopyOrNull();
            __result = copiedResultFFS;
        }
    }
}
