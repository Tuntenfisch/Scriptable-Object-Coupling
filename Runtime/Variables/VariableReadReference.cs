using System;
using Tuntenfisch.ScriptableObjectCoupling.Common;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Variables
{
    [Serializable]
    public sealed class VariableReadReference<T> : VariableReference<T>
    {
        #region Public Properties
        public override T CurrentValue
        {
            get
            {
                return base.CurrentValue;
            }

            set
            {
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region Protected Properties
        protected override Variable<T> Variable => m_variable;
        #endregion

        #region Inspector Fields
        [AccessHint(AccessFlags.Read)]
        [SerializeField]
        private Variable<T> m_variable;
        #endregion
    }
}