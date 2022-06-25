
using UnityEngine;

namespace InfimaGames.LowPolyShooterPack
{
    public class Magazine : MagazineBehaviour
    {
        [Header("Settings")]
        
        [Tooltip("Total Ammunition.")]
        [SerializeField]
        private int ammunitionTotal = 10;

        [Header("Interface")]

        [Tooltip("Interface Sprite.")]
        [SerializeField]
        private Sprite sprite;

        public override int GetAmmunitionTotal() => ammunitionTotal;

        public override Sprite GetSprite() => sprite;

    }
}