using AmongUs.Data.Legacy;
using System.Collections.Generic;
using System.Linq;
using TheOtherRoles.Utilities;
using UnityEngine;
using Object = Il2CppSystem.Object;

namespace TheOtherRoles.Modules;

public class CustomColors
{
    protected static Dictionary<int, string> ColorStrings = new();
    public static List<int> lighterColors = new() { 3, 4, 5, 7, 10, 11, 13, 14, 17 };
    public static uint pickableColors = (uint)Palette.ColorNames.Length;

    private static readonly List<int> ORDER = new()
    {
        7, 37, 14, 5, 33, 41, 25,
        4, 30, 0, 35, 3, 27, 17,
        13, 23, 8, 32, 38, 1, 21,
        40, 31, 10, 34, 22, 28, 36,
        2, 11, 26, 29, 20, 19, 18,
        12, 9, 24, 16, 15, 6, 39
    };

    public static void Load()
    {
        var longlist = Palette.ColorNames.ToList();
        var colorlist = Palette.PlayerColors.ToList();
        var shadowlist = Palette.ShadowColors.ToList();

        var colors = new List<CustomColor>();

        /* Custom Colors, starting with id (for ORDER) 18 */
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorTamarind"), //18
            color = new Color32(48, 28, 34, byte.MaxValue),
            shadow = new Color32(30, 11, 16, byte.MaxValue),
            isLighterColor = true
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorArmy"),
            color = new Color32(39, 45, 31, byte.MaxValue),
            shadow = new Color32(11, 30, 24, byte.MaxValue),
            isLighterColor = false
        });
        // 20
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorOlive"),
            color = new Color32(154, 140, 61, byte.MaxValue),
            shadow = new Color32(104, 95, 40, byte.MaxValue),
            isLighterColor = true
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorTurquoise"),
            color = new Color32(22, 132, 176, byte.MaxValue),
            shadow = new Color32(15, 89, 117, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorMint"),
            color = new Color32(111, 192, 156, byte.MaxValue),
            shadow = new Color32(65, 148, 111, byte.MaxValue),
            isLighterColor = true
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorLavender"),
            color = new Color32(173, 126, 201, byte.MaxValue),
            shadow = new Color32(131, 58, 203, byte.MaxValue),
            isLighterColor = true
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorNougat"),
            color = new Color32(160, 101, 56, byte.MaxValue),
            shadow = new Color32(115, 15, 78, byte.MaxValue),
            isLighterColor = false
        });
        // 25
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorPeach"),
            color = new Color32(255, 164, 119, byte.MaxValue),
            shadow = new Color32(238, 128, 100, byte.MaxValue),
            isLighterColor = true
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorWasabi"),
            color = new Color32(112, 143, 46, byte.MaxValue),
            shadow = new Color32(72, 92, 29, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorHotPink"),
            color = new Color32(255, 51, 102, byte.MaxValue),
            shadow = new Color32(232, 0, 58, byte.MaxValue),
            isLighterColor = true
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorPetrol"),
            color = new Color32(0, 99, 105, byte.MaxValue),
            shadow = new Color32(0, 61, 54, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorLemon"),
            color = new Color32(0xDB, 0xFD, 0x2F, byte.MaxValue),
            shadow = new Color32(0x74, 0xE5, 0x10, byte.MaxValue),
            isLighterColor = true
        });
        // 30
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorSignalOrange"),
            color = new Color32(0xF7, 0x44, 0x17, byte.MaxValue),
            shadow = new Color32(0x9B, 0x2E, 0x0F, byte.MaxValue),
            isLighterColor = true
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorTeal"),
            color = new Color32(0x25, 0xB8, 0xBF, byte.MaxValue),
            shadow = new Color32(0x12, 0x89, 0x86, byte.MaxValue),
            isLighterColor = true
        });

        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorBlurple"),
            color = new Color32(61, 44, 142, byte.MaxValue),
            shadow = new Color32(25, 14, 90, byte.MaxValue),
            isLighterColor = false
        });

        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorSunrise"),
            color = new Color32(0xFF, 0xCA, 0x19, byte.MaxValue),
            shadow = new Color32(0xDB, 0x44, 0x42, byte.MaxValue),
            isLighterColor = true
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorIce"),
            color = new Color32(0xA8, 0xDF, 0xFF, byte.MaxValue),
            shadow = new Color32(0x59, 0x9F, 0xC8, byte.MaxValue),
            isLighterColor = true
        });
        // 35
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorFuchsia"),//35 Color Credit: LaikosVK
            color = new Color32(164, 17, 129, byte.MaxValue),
            shadow = new Color32(104, 3, 79, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorRoyalGreen"),//36
            color = new Color32(9, 82, 33, byte.MaxValue),
            shadow = new Color32(0, 46, 8, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorSlime"),
            color = new Color32(244, 255, 188, byte.MaxValue),
            shadow = new Color32(167, 239, 112, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorNavy"),//38
            color = new Color32(9, 43, 119, byte.MaxValue),
            shadow = new Color32(0, 13, 56, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorDarkness"),//39
            color = new Color32(36, 39, 40, byte.MaxValue),
            shadow = new Color32(10, 10, 10, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorOcean"),//40
            color = new Color32(55, 159, 218, byte.MaxValue),
            shadow = new Color32(62, 92, 158, byte.MaxValue),
            isLighterColor = false
        });
        colors.Add(new CustomColor
        {
            longname = ModTranslation.getString("colorSundown"),//41
            color = new Color32(252, 194, 100, byte.MaxValue),
            shadow = new Color32(197, 98, 54, byte.MaxValue),
            isLighterColor = false
        });
        pickableColors += (uint)colors.Count; // Colors to show in Tab
        /** Hidden Colors **/

        /** Add Colors **/
        var id = 50000;
        foreach (var cc in colors)
        {
            longlist.Add((StringNames)id);
            ColorStrings[id++] = cc.longname;
            colorlist.Add(cc.color);
            shadowlist.Add(cc.shadow);
            if (cc.isLighterColor)
                lighterColors.Add(colorlist.Count - 1);
        }


        Palette.ColorNames = longlist.ToArray();
        Palette.PlayerColors = colorlist.ToArray();
        Palette.ShadowColors = shadowlist.ToArray();
    }

    protected internal struct CustomColor
    {
        public string longname;
        public Color32 color;
        public Color32 shadow;
        public bool isLighterColor;
    }

    [HarmonyPatch]
    public static class CustomColorPatches
    {
        [HarmonyPatch(typeof(TranslationController), nameof(TranslationController.GetString), typeof(StringNames),
            typeof(Il2CppReferenceArray<Object>))]
        private class ColorStringPatch
        {
            [HarmonyPriority(Priority.Last)]
            public static bool Prefix(ref string __result, [HarmonyArgument(0)] StringNames name)
            {
                if ((int)name >= 50000)
                {
                    var text = ColorStrings[(int)name];
                    if (text != null)
                    {
                        __result = text;
                        return false;
                    }
                }

                return true;
            }
        }

        [HarmonyPatch(typeof(PlayerTab), nameof(PlayerTab.OnEnable))]
        private static class PlayerTabEnablePatch
        {
            public static void Postfix(PlayerTab __instance)
            {
                // Replace instead
                var chips = __instance.ColorChips.ToArray();

                var cols = 7; // TODO: Design an algorithm to dynamically position chips to optimally fill space
                for (var i = 0; i < ORDER.Count; i++)
                {
                    var pos = ORDER[i];
                    if (pos < 0 || pos > chips.Length)
                        continue;
                    var chip = chips[pos];
                    int row = i / cols, col = i % cols; // Dynamically do the positioning
                    chip.transform.localPosition = new Vector3(-0.975f + (col * 0.5f), 1.475f - (row * 0.5f),
                        chip.transform.localPosition.z);
                    chip.transform.localScale *= 0.76f;
                }

                for (var j = ORDER.Count; j < chips.Length; j++)
                {
                    // If number isn't in order, hide it
                    var chip = chips[j];
                    chip.transform.localScale *= 0f;
                    chip.enabled = false;
                    chip.Button.enabled = false;
                    chip.Button.OnClick.RemoveAllListeners();
                }
            }
        }

        [HarmonyPatch(typeof(LegacySaveManager), nameof(LegacySaveManager.LoadPlayerPrefs))]
        private static class LoadPlayerPrefsPatch
        {
            // Fix Potential issues with broken colors
            private static bool needsPatch;

            public static void Prefix([HarmonyArgument(0)] bool overrideLoad)
            {
                if (!LegacySaveManager.loaded || overrideLoad)
                    needsPatch = true;
            }

            public static void Postfix()
            {
                if (!needsPatch) return;
                LegacySaveManager.colorConfig %= pickableColors;
                needsPatch = false;
            }
        }

        [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.CheckColor))]
        private static class PlayerControlCheckColorPatch
        {
            private static bool isTaken(PlayerControl player, uint color)
            {
                foreach (var p in GameData.Instance.AllPlayers.GetFastEnumerator())
                    if (!p.Disconnected && p.PlayerId != player.PlayerId && p.DefaultOutfit.ColorId == color)
                        return true;
                return false;
            }

            public static bool Prefix(PlayerControl __instance, [HarmonyArgument(0)] byte bodyColor)
            {
                // Fix incorrect color assignment
                uint color = bodyColor;
                if (isTaken(__instance, color) || color >= Palette.PlayerColors.Length)
                {
                    var num = 0;
                    while (num++ < 50 && (color >= pickableColors || isTaken(__instance, color)))
                        color = (color + 1) % pickableColors;
                }

                __instance.RpcSetColor((byte)color);
                return false;
            }
        }
    }
}