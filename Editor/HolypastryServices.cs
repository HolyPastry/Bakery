using UnityEditor;

namespace Holypastry.Bakery.Editor
{
    public static class HolypastryServices
    {

        [MenuItem("Bakery/Install/Services/Quests")]
        public static void InstallQuestManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/QuestServices.git" });
        }

        [MenuItem("Bakery/Install/Services/Cutscenes")]
        public static void InstallCutsceneManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/CutsceneServices.git" });
        }

        [MenuItem("Bakery/Install/Services/Music")]
        public static void InstallMusicManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/MusicServices.git" });
        }

        [MenuItem("Bakery/Install/Services/Dialogs")]
        public static void InstallDialogManager()
        {
            // HolypastryFeatures.InstallInk();
            Packages.Install(new[] { "https://github.com/HolyPastry/DialogServices.git" });

        }
        [MenuItem("Bakery/Install/Services/Camera")]
        public static void InstallCameraManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/CameraServices.git" });
        }
        [MenuItem("Bakery/Install/Services/Time")]
        public static void InstallTimeManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/TimeServices.git" });
        }


        [MenuItem("Bakery/Install/Services/Flow")]
        public static void InstallFlowManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/FlowServices.git" });
        }

        [MenuItem("Bakery/Install/Services/Input")]
        public static void InstallInputManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/InputServices.git" });
        }

        [MenuItem("Bakery/Install/Services/Saves")]
        public static void InstallSaveManager()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/SaveServices.git" });
        }


        [MenuItem("Bakery/Install/Services/Cheat")]
        public static void InstallCheatManager()
        {
            Assets.ImportFromLocal("Cheat");
        }

        [MenuItem("Bakery/Install/Services/Google Sheets")]
        public static void InstallGoogleSheets()
        {
            Assets.ImportFromLocal("GoogleSheet");
        }

        [MenuItem("Bakery/Install/Services/TTS")]
        public static void InstallTTS()
        {
            Packages.Install(new[] { "https://github.com/HolyPastry/TextToSpeech.git" });
        }

        [MenuItem("Bakery/Install/Services/NPCs")]
        public static void InstallNpcs()
        {
            Assets.ImportFromLocal("NPC");
        }

    }
}