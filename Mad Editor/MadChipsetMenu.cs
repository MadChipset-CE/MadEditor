#if UNITY_EDITOR
    using UnityEditor;
using UnityEngine;

public static class MadChipsetMenu {
            const string HiddenGameObjects = "Mad Chipset/Show Hidden Objects";


            [MenuItem(HiddenGameObjects)] 
            static void ToggleShowHiddenObjects() { 
                EditorPrefs.SetBool(Constants.HIDDEN_FLAG, !EditorPrefs.GetBool(Constants.HIDDEN_FLAG, false));
                foreach(HiddenObject hiddenObject in GameObject.FindObjectsByType<HiddenObject>(FindObjectsSortMode.None)) {
                    hiddenObject.RefreshHiddenState();
                }
            }

            [MenuItem(HiddenGameObjects, true)] 
            static bool ToggleShowHiddenObjectsValidation() {
        UnityEditor.Menu.SetChecked(HiddenGameObjects, !EditorPrefs.GetBool(Constants.HIDDEN_FLAG, false));
                return true;
            }

        }
#endif