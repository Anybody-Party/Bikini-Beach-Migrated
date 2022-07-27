using _BikiniPunchBeachBattle3D.Characters;
using _BikiniPunchBeachBattle3D.Scripts.Domain;
using RH.Utilities.ServiceLocator;
using UnityEngine.Events;

namespace _BikiniPunchBeachBattle3D.GameServices
{
    public class EventsMediator : IService
    {
        public UnityEvent<StatType> Upgraded = new();
        public UnityEvent MoneysCountChanged = new();
        public UnityEvent<CharacterType> HealthAmountChanged = new();
        public UnityEvent<CharacterType, float> StaminaAmountChanged = new();
        public UnityEvent<CharacterType, string> PunchPerformed = new();
        public UnityEvent OpponentDefeated = new();
        public UnityEvent<float> RageValueChanged = new();
        public UnityEvent RewardedShown = new();
        public UnityEvent GlovesColorChanged = new();
    }
}