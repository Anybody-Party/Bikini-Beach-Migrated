using UnityEngine;

namespace _BikiniPunchBeachBattle3D.GameServices
{
    public class GlovesForOffer : MonoBehaviour
    {
        [SerializeField] private MeshRenderer[] _meshRenderers;

        public void SetColor(Color color)
        {
            foreach (MeshRenderer meshRenderer in _meshRenderers) 
                meshRenderer.material.color = color;
        }
    }
}