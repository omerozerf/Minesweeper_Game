using MyGrid.Code;
using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class Unit : MonoBehaviour
    {
        private UnitState unitState;

        
        [SerializeField] private SpriteRenderer mySpriteRenderer;
        [SerializeField] private TextMeshPro text;
        [SerializeField] private TileController tileController;
        

        public void Prepare(UnitState unitState)
        {
            this.unitState = unitState;

            mySpriteRenderer.color = this.unitState == UnitState.Mine ? Color.red : Color.white;
        }


        public void PrepareText()
        {
            if (unitState == UnitState.Mine)
            {
                text.text = "";
            }

            else
            {
                var list = tileController.GetAllNeighbours();

                int count = 0;
                foreach (var item in list)
                {
                    Unit unit = item.GetComponent<Unit>();

                    if (unit.unitState == UnitState.Mine) count++;
                }

                text.text = count.ToString();
            }
        }
    }
}