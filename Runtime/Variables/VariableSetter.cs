using Tuntenfisch.ScriptableObjectCoupling.Common;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Variables
{
    public sealed class VariableSetter : MonoBehaviour
    {
        #region Inspector Fields
        [SerializeField]
        private VariableType m_variableType;

        [AccessHint(AccessFlags.Write)]
        [SerializeField]
        private Variable<Camera> m_cameraVariable;
        [SerializeField]
        private Camera m_cameraValue;

        [AccessHint(AccessFlags.Write)]
        [SerializeField]
        private Variable<GameObject> m_gameObjectVariable;
        [SerializeField]
        private GameObject m_gameObjectValue;

        [AccessHint(AccessFlags.Write)]
        [SerializeField]
        private Variable<Transform> m_transformVariable;
        [SerializeField]
        private Transform m_transformValue;
        #endregion

        #region Unity Events
        private void Awake()
        {
            switch (m_variableType)
            {
                case VariableType.Camera:
                    m_cameraVariable.CurrentValue = m_cameraValue;
                    break;

                case VariableType.GameObject:
                    m_gameObjectVariable.CurrentValue = m_gameObjectValue;
                    break;

                case VariableType.Transform:
                    m_transformVariable.CurrentValue = m_transformValue;
                    break;
            }
        }
        #endregion

        #region Public Structs, Classes and Enums
        public enum VariableType
        {
            Camera,
            GameObject,
            Transform
        }
        #endregion
    }
}