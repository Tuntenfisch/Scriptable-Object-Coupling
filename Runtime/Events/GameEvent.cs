using System;
using UnityEngine;

namespace Tuntenfisch.ScriptableObjectCoupling.Events
{
    [CreateAssetMenu(fileName = "Game Event", menuName = "Tuntenfisch/Commons/Coupling/Events/New Game Event")]
    public sealed class GameEvent : ScriptableObject
    {
        #region Events
        public event Action OnGameEventInvoked;
        #endregion

        #region Public Methods
        public void InvokeGameEvent()
        {
            OnGameEventInvoked?.Invoke();
        }
        #endregion
    }
}