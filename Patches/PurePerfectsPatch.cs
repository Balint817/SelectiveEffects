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
using MelonLoader;

namespace SelectiveEffects.Patches
{
    class PurePerfectsPatch
    {
        static bool _isPatched = false;

        static MethodBase TargetMethod()
        {
            return AccessTools.Method(typeof(JudgeDisplay), nameof(JudgeDisplay.OnEnable));
        }
        public static void Reload(HarmonyLib.Harmony harmonyInstance)
        {
            var postfix = Postfix;
            var postfixInfo = postfix.Method;
            if (SettingsManager.DisableJudgement || SettingsManager.DisablePerfects || !SettingsManager.DisablePurePerfects)
            {
                if (_isPatched)
                {
                    harmonyInstance.Unpatch(TargetMethod(), postfixInfo);
                    _isPatched = false;
                }
                return;
            }
            if (!_isPatched)
            {
                harmonyInstance.Patch(TargetMethod(), postfix: postfixInfo.ToNewHarmonyMethod());
                _isPatched = true;
            }
        }
        static void Postfix(JudgeDisplay __instance)
        {
            if (!SettingsManager.Enabled
                || TaskStageTarget.instance.m_Score < 1) return;
            var battleRole = BattleRoleAttributeComponent.instance;
            if (!battleRole.m_IsShowLateEarly) return;
            __instance.gameObject.SetActive(battleRole.m_JudgeState != 0);
        }
    }
}
