using UnityEngine;

namespace _Scripts
{
    public class Unit : MonoBehaviour
    {
        private UnitState unitState;

        
        [SerializeField] private SpriteRenderer spriteRenderer;


        public void Prepare(UnitState unitState)
        {
            this.unitState = unitState;
        }
    }
}