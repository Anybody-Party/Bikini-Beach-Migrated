using _Game.GameServices;
using UnityEngine;

namespace _BikiniPunchBeachBattle3D.UI.Windows
{
    public class HudWindow : BaseWindow
    {
        [SerializeField] private GameObject _fightButton;

        private void OnEnable()
        {
            if (!_fightButton.activeSelf)
                _fightButton.SetActive(true);
        }
    }
}