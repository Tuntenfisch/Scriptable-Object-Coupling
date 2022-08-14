using Tuntenfisch.ScriptableObjectCoupling.Common.Editor;
using UnityEditor;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Variables.Editor
{
    [CustomPropertyDrawer(typeof(Variable<>), useForChildren: true)]
    public class VariableDrawer : PropertyDrawer
    {
        #region Unity Events
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            MyEditorGUI.GenericObjectField(position, label, property, fieldInfo.FieldType);
        }
        #endregion
    }
}