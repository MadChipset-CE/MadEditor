#if UNITY_EDITOR
    using UnityEngine;

    [AddComponentMenu("MadEditor/HiddenObject")]
    public class HiddenObject : MonoBehaviour
    {
        [SerializeField] private bool isHidden = true;

        private void OnValidate() {
            RefreshHiddenState();
        }

        public void RefreshHiddenState() {
            gameObject.hideFlags = isHidden && UnityEditor.EditorPrefs.GetBool(Constants.HIDDEN_FLAG) ? HideFlags.HideInHierarchy : HideFlags.None;
        }
    }
#endif