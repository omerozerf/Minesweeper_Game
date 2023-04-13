using UnityEngine;

namespace _Scripts
{
    public class Unit : MonoBehaviour
    {
        private UnitState unitState;

        
        [SerializeField] private SpriteRenderer mySpriteRenderer;


        public void Prepare(UnitState unitState)
        {
            this.unitState = unitState;

            mySpriteRenderer.color = this.unitState == UnitState.Mine ? Color.red : Color.white;
        }
    }
}