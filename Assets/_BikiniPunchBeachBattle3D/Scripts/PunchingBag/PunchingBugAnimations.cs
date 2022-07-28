using _BikiniPunchBeachBattle3D.Characters;
using _BikiniPunchBeachBattle3D.GameServices;
using RH.Utilities.ServiceLocator;
using UnityEngine;

namespace _BikiniPunchBeachBattle3D.PunchingBag
{
    public class PunchingBugAnimations : MonoBehaviour
    {
        private static readonly string[] _triggersNames = {"Hit_0", "Hit_1", "Hit_2", "Hit_3"};
        
        [SerializeField] private Animator _animator;
        
        private EventsMediator _events;

        private void Start()
        {
            _events = Services.Get<EventsMediator>();
            _events.PunchPerformed.AddListener(Animate);
        }

        private void Animate(CharacterType characterType, string side) => 
            _animator.SetTrigger(_triggersNames[Random.Range(0, _triggersNames.Length)]);
    }
}