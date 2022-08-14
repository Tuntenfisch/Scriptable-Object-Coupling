using System;
using Tuntenfisch.ScriptableObjectCoupling.Common;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Variables
{
    [Serializable]
    public sealed class VariableWriteReference<T> : VariableReference<T>
    {
        #region Events
        public override event Action<T> OnCurrentValueChanged
        {
            add
            {
                throw new InvalidOperationException();
            }

            remove
            {
                throw new InvalidOperationException();
            }
        }
        #endregion

        #region Public Properties
        public override T CurrentValue
        {
            get
            {
                throw new InvalidOperationException();
            }

            set
            {
                base.CurrentValue = value;
            }
        }
        #endregion

        #region Protected Properties
        protected override Variable<T> Variable => m_variable;
        #endregion

        #region Inspector Fields
        [AccessHint(AccessFlags.Write)]
        [SerializeField]
        private Variable<T> m_variable;
        #endregion
    }
}