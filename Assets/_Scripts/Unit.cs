using System;
using MyGrid.Code;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts
{
    public class Unit : MonoBehaviour
    {
        public UnitState unitState;

        
        [SerializeField] private SpriteRenderer SpriteRenderer;

        public SpriteRenderer Mask => mask;
        [SerializeField] private SpriteRenderer mask;

        public SpriteRenderer Flag => flag;
        [SerializeField] private SpriteRenderer flag;

        public SpriteRenderer Mine => mine;
        [SerializeField] private SpriteRenderer mine;
        
        
        [SerializeField] private TextMeshPro text;
        [SerializeField] private TileController tileController;


        private int countMine;


        private void Start()
        {
            flag.enabled = false;
        }


        public void SetUnit(UnitState unitState)
        {
            this.unitState = unitState;

            SpriteRenderer.color = this.unitState == UnitState.Mine ? Color.red : Color.white;
            mine.enabled = this.unitState == UnitState.Mine;
        }


        public void UpdateText()
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

                string result = count > 0 ? count.ToString() : "";
                text.text = result;
                countMine = count;
            }
        }


        public void Open()
        {
            if(!IsOpen()) return;
            
            
            mask.enabled = false;


            if (unitState == UnitState.Mine)
            {
                GameController.Instance.TouchMine();
                return;
            }
            

            if (countMine == 0)
            {
                var neighbourList = tileController.GetAllNeighbours();
                foreach (var neighbour in neighbourList)
                {
                    Unit unit = neighbour.GetComponent<Unit>();
                    unit.Open();
                }
            }
        }


        public bool IsOpen()
        {
            return mask.enabled && !flag.enabled && StartButton.Instance.isStart;
        }
    }
}