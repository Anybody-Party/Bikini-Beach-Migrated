using _BikiniPunchBeachBattle3D.Characters;
using _BikiniPunchBeachBattle3D.GameServices;
using Cinemachine;
using RH.Utilities.ServiceLocator;
using UnityEngine;

namespace _BikiniPunchBeachBattle3D.Effects
{
    [RequireComponent(typeof(CinemachineImpulseSource))]
    public class PunchCameraImpulseProvider : MonoBehaviour
    {
        private CinemachineImpulseSource _impulseSource;
        private EventsMediator _events;

        private void Start()
        {
            _impulseSource = GetComponent<CinemachineImpulseSource>();
            _events = Services.Get<EventsMediator>();
        
            _events.PunchPerformed.AddListener(Shake);
        }

        private void OnDestroy() => 
            _events.PunchPerformed.RemoveListener(Shake);

        private void Shake(CharacterType arg0, string side) => 
            _impulseSource.GenerateImpulse();
    }
}
