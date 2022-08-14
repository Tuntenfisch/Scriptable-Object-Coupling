using Tuntenfisch.ScriptableObjectCoupling.Common;
using Tuntenfisch.ScriptableObjectCoupling.Sets;
using Tuntenfisch.ScriptableObjectCoupling.Variables;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Specialized
{
    public abstract class AddMonoBehaviourWhileTargetInsideTrigger<T> : MonoBehaviour where T : MonoBehaviour
    {
        #region Inspector Fields
        [AccessHint(AccessFlags.Write)]
        [SerializeField]
        private RuntimeSet<T> m_runtimeSet;
        [AccessHint(AccessFlags.Read)]
        [SerializeField]
        private Variable<GameObject> m_target;
        #endregion

        #region Private Fields
        private T m_monobehaviour;
        #endregion

        #region Unity Events
        private void Awake()
        {
            m_monobehaviour = GetComponent<T>();

            if (m_monobehaviour == null)
            {
                Debug.LogWarning($"{nameof(GameObject)} does not have a {nameof(T)} component attached.", gameObject);
            }
        }

        private void OnDestroy()
        {
            if (m_runtimeSet.Contains(m_monobehaviour))
            {
                m_runtimeSet.Remove(m_monobehaviour);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (m_monobehaviour == null || other.gameObject != m_target.CurrentValue)
            {
                return;
            }
            m_runtimeSet.Add(m_monobehaviour);
        }

        private void OnTriggerExit(Collider other)
        {
            if (m_monobehaviour == null || other.gameObject != m_target.CurrentValue)
            {
                return;
            }
            m_runtimeSet.Remove(m_monobehaviour);
        }
        #endregion
    }
}