using Tuntenfisch.ScriptableObjectCoupling.Common;
using UnityEngine;
using UnityEngine.Events;

namespace Tuntenfisch.ScriptableObjectCoupling.Events
{
    public sealed class GameEventListener : MonoBehaviour
    {
        #region Public Properties
        public GameEvent GameEvent => m_gameEvent;
        public UnityEvent Response => m_response;
        #endregion

        #region Inspector Fields
        [AccessHint(AccessFlags.Read)]
        [Tooltip("Game event to register with.")]
        [SerializeField]
        private GameEvent m_gameEvent;
        [Tooltip("Response to invoke when game event is raised.")]
        [SerializeField]
        private UnityEvent m_response;
        #endregion

        #region Unity Events
        private void OnEnable()
        {
            m_gameEvent.OnGameEventInvoked += OnGameEventInvoked;
        }

        private void OnDisable()
        {
            m_gameEvent.OnGameEventInvoked -= OnGameEventInvoked;
        }
        #endregion

        #region Private Methods
        private void OnGameEventInvoked()
        {
            m_response.Invoke();
        }
        #endregion
    }
}