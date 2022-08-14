using Tuntenfisch.ScriptableObjectCoupling.Common.Editor;
using UnityEditor;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Sets.Editor
{
    [CustomPropertyDrawer(typeof(RuntimeSet<>), useForChildren: true)]
    public class RuntimeSetDrawer : PropertyDrawer
    {
        #region Unity Events
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            MyEditorGUI.GenericObjectField(position, label, property, fieldInfo.FieldType);
        }
        #endregion
    }
}