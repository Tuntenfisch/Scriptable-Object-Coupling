using System;
using UnityEditor;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Common.Editor
{
    public static class MyEditorGUI
    {
        #region Public Methods
        public static void GenericObjectField(Rect position, GUIContent label, SerializedProperty property, Type baseType)
        {
            TypeCache.TypeCollection collection = TypeCache.GetTypesDerivedFrom(baseType);
            property.objectReferenceValue = UnityEditor.EditorGUI.ObjectField(position, label, property.objectReferenceValue, collection.Count > 0 ? collection[0] : null, false);
        }

        public static int PropertyFieldWithPaneOptions(Rect position, GUIContent label, SerializedProperty property, int selectedPaneOption, string[] paneOptions)
        {
            (Rect fieldRect, Rect paneOptionsRect) = GetFieldAndPaneOptionsRect(position, label);

            if (property != null)
            {
                UnityEditor.EditorGUI.PropertyField(fieldRect, property, GUIContent.none);
            }
            return PaneOptions(paneOptionsRect, selectedPaneOption, paneOptions);
        }

        public static int PaneOptions(Rect position, int selectedPaneOptionIndex, string[] popupOptions)
        {
            Rect rect = new Rect(position.x, position.y + 0.5f * (position.height - EditorGUIStyles.PaneOptionsSytle.fixedHeight), EditorGUIStyles.PaneOptionsSytle.fixedWidth, position.height);
            return UnityEditor.EditorGUI.Popup(rect, selectedPaneOptionIndex, popupOptions, EditorGUIStyles.PaneOptionsSytle);
        }
        #endregion

        #region Private Methods
        private static (Rect, Rect) GetFieldAndPaneOptionsRect(Rect position, GUIContent label)
        {
            Rect controlRect = UnityEditor.EditorGUI.PrefixLabel(position, label);
            Rect fieldRect = new Rect(controlRect.x, controlRect.y, controlRect.width - EditorGUIStyles.PaneOptionsSytle.fixedWidth - MyEditorGUIUtility.Spacing.x, controlRect.height);
            Rect paneOptionsRect = new Rect(fieldRect.xMax + MyEditorGUIUtility.Spacing.x, controlRect.y, EditorGUIStyles.PaneOptionsSytle.fixedWidth, fieldRect.height);

            return (fieldRect, paneOptionsRect);
        }
        #endregion
    }
}