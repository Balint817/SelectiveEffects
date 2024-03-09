using Il2Cpp;
using Il2CppAssets.Scripts.GameCore.HostComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using System.Reflection;
using SelectiveEffects.Managers;

namespace SelectiveEffects.Patches
{
    [HarmonyPatch(typeof(JudgeDisplay), nameof(JudgeDisplay.OnEnable))]
    class PurePerfectsPatch
    {
        static void Postfix(JudgeDisplay __instance)
        {
            if (!SettingsManager.DisablePurePerfects || TaskStageTarget.instance.m_Score < 1) return;
            var battleRole = BattleRoleAttributeComponent.instance;
            if (!battleRole.m_IsShowLateEarly) return;
            __instance.gameObject.SetActive(battleRole.m_JudgeState != 0);
        }
    }
}
