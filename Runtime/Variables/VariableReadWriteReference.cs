using System;
using Tuntenfisch.ScriptableObjectCoupling.Common;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Variables
{
    [Serializable]
    public sealed class VariableReadWriteReference<T> : VariableReference<T>
    {
        #region Protected Properties
        protected override Variable<T> Variable => m_variable;
        #endregion

        #region Inspector Fields
        [AccessHint(AccessFlags.Read | AccessFlags.Write)]
        [SerializeField]
        private Variable<T> m_variable;
        #endregion
    }
}