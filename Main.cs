using MelonLoader;
using SelectiveEffects.Managers;
using SelectiveEffects.Patches;

namespace SelectiveEffects
{
    public class Main : MelonMod
    {
        internal static bool _isGameMain = false;
        public static bool IsGameMain => _isGameMain;

        public override void OnInitializeMelon()
        {
            SettingsManager.Load();
            EffectsDisablerManager.Init(this.HarmonyInstance);
            LoggerInstance.Msg("SelectiveEffects loaded correctly!");
            //MelonPreferences.OnPreferencesLoaded.Subscribe(PreferencesLoaded);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            _isGameMain = sceneName.Equals("GameMain");
        }
        //TODO: Figure out why the MelonPreferences.OnPreferencesLoaded event never fires.
        //void PreferencesLoaded(string path)
        //{
        //    EffectsDisablerManager.Init(this.HarmonyInstance);
        //    MelonLogger.Msg("SelectiveEffects reloaded correctly!");
        //}
    }
}
