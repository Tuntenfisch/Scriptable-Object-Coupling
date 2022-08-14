using System;
using System.Reflection;
using UnityEditor;

namespace Tuntenfisch.ScriptableObjectCoupling.Common.Editor
{
    public static class SerializedPropertyExtensions
    {
        #region Private Fields
        private const BindingFlags c_bindingFlags = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance;
        #endregion

        #region Public Methods
        public static T GetAttribute<T>(this SerializedProperty property) where T : Attribute
        {
            FieldInfo fieldInfo = property.GetFieldInfo();

            if (fieldInfo == null)
            {
                return default;
            }
            return fieldInfo.GetCustomAttribute<T>();
        }

        public static FieldInfo GetFieldInfo(this SerializedProperty property)
        {
            FieldInfo fieldInfo = null;
            Type type = property.serializedObject.targetObject.GetType();

            foreach (string fieldName in property.propertyPath.Split('.'))
            {
                while (type != null)
                {
                    fieldInfo = type.GetField(fieldName, c_bindingFlags);

                    if (fieldInfo != null)
                    {
                        type = fieldInfo.FieldType;

                        break;
                    }
                    type = type.BaseType;
                }
            }
            return fieldInfo;
        }
        #endregion
    }
}