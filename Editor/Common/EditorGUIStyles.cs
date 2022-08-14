using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Common.Editor
{
    public static class EditorGUIStyles
    {
        #region Public Fields
        public static readonly GUIStyle CenteredLabelStyle;
        public static readonly GUIStyle PaneOptionsSytle;
        public static readonly GUIStyle CenteredBoldLabelStyle;
        public static readonly GUIStyle CenteredBlackLabelStyle;
        #endregion

        static EditorGUIStyles()
        {
            CenteredLabelStyle = new GUIStyle(GUI.skin.label);
            CenteredLabelStyle.alignment = TextAnchor.MiddleCenter;
            CenteredLabelStyle.richText = true;

            PaneOptionsSytle = new GUIStyle("PaneOptions");
            PaneOptionsSytle.imagePosition = ImagePosition.ImageOnly;

            CenteredBoldLabelStyle = new GUIStyle(GUI.skin.label);
            CenteredBoldLabelStyle.alignment = TextAnchor.MiddleCenter;
            CenteredBoldLabelStyle.fontStyle = FontStyle.Bold;
            CenteredBoldLabelStyle.richText = true;

            CenteredBlackLabelStyle = new GUIStyle(GUI.skin.label);
            CenteredBlackLabelStyle.alignment = TextAnchor.MiddleCenter;
            CenteredBlackLabelStyle.normal.textColor = Color.black;
            CenteredBlackLabelStyle.richText = true;
        }
    }
}