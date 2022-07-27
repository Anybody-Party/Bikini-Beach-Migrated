using System;
using RH.Utilities.Saving;
using UnityEngine;

namespace _Game.Data
{
    [Serializable]
    public class SavableData : ISavableData
    {
        public string Key => "Save";
        
        public Color GlovesColor;

        public int OpponentLevel;
        public int MoneyAmount;

        public CharacterStats Player = new();
        
        [NonSerialized] public CharacterStats Opponent = new();
    }
}