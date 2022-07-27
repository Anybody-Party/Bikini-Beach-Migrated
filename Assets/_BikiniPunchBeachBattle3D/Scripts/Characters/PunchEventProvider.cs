using System;
using _BikiniPunchBeachBattle3D.GameServices;
using RH.Utilities.ServiceLocator;
using UnityEngine;

namespace _BikiniPunchBeachBattle3D.Characters
{
    public class PunchEventProvider : MonoBehaviour
    {
        [SerializeField] private CharacterType _characterType;
        
        private EventsMediator _events;

        private void Start() => 
            _events = Services.Get<EventsMediator>();

        private void PerformPunch(string side) => 
            _events.PunchPerformed?.Invoke(_characterType, side);
    }
}