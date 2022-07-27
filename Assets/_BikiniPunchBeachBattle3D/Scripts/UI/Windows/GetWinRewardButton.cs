using _BikiniPunchBeachBattle3D.GameServices;
using _Game.GameServices;
using RH.Utilities.ServiceLocator;
using RH.Utilities.UI;

namespace _BikiniPunchBeachBattle3D.UI.Windows
{
    public class GetWinRewardButton : BaseActionButton
    {
        private Wallet _wallet;
        private WindowsService _windowsService;
        private DataService _data;

        protected override void PerformOnStart()
        {
            _wallet = Services.Get<Wallet>();
            _windowsService = Services.Get<WindowsService>();
            _data = Services.Get<DataService>();
        }

        protected override void PerformOnClick()
        {
            int reward = _data.GetWinReward();
            _wallet.Add(reward);
            
            _windowsService.Hide(_windowsService.TopWindow);
            _windowsService.Show<HudWindow>();
        }
    }
}