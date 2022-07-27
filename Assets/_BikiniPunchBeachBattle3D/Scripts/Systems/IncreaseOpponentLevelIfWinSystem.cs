using RH.Utilities.PseudoEcs;

namespace _Game.Logic.Systems
{
    public class IncreaseOpponentLevelIfWinSystem : BaseInitSystem
    {
        public override void Init() => 
            _events.OpponentDefeated.AddListener(CreateNewIfItsPunchingBag);

        public override void Dispose() => 
            _events.OpponentDefeated.RemoveListener(CreateNewIfItsPunchingBag);

        private void CreateNewIfItsPunchingBag()
        {
            if (!_data.CurrentOpponentGO.name.Contains("PunchingBag"))
                _data.SavableData.OpponentLevel++;
        }
    }
}