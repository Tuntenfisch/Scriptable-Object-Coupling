using Tuntenfisch.ScriptableObjectCoupling.Common;
using Tuntenfisch.ScriptableObjectCoupling.Sets;
using Tuntenfisch.ScriptableObjectCoupling.Variables;
using Unity.Mathematics;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Specialized
{
    public abstract class FindClosestMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        #region Inspector Fields
        [AccessHint(AccessFlags.Read)]
        [SerializeField]
        private RuntimeSet<T> m_runtimeSet;
        [AccessHint(AccessFlags.Write)]
        [SerializeField]
        private Variable<T> m_output;
        #endregion

        #region Unity Events
        private void Update()
        {
            float shortestDistanceSquared = float.MaxValue;
            T closestMonoBehaviour = null;

            foreach (T monoBehaviour in m_runtimeSet)
            {
                float distanceSquared = math.lengthsq(monoBehaviour.transform.position - transform.position);

                if (distanceSquared < shortestDistanceSquared)
                {
                    shortestDistanceSquared = distanceSquared;
                    closestMonoBehaviour = monoBehaviour;
                }
            }
            m_output.CurrentValue = closestMonoBehaviour;
        }
        #endregion
    }
}