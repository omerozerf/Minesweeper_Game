using System;
using MyGrid.Code;
using UnityEngine;

namespace _Scripts
{
    public class TouchManager : MonoBehaviour
    {
        public static event EventHandler<int> OnFlagCountChanged;
        
        
        [SerializeField] private Unit unit;
        

        private bool hasFlag = false;
        
        
        private void OnMouseUp()
        {
            if (!GetUnitHasFlag() && StartButton.Instance.isStart)
            {
                // unit.Mask.enabled = false;
                unit.Open();
            }
        }


        private void OnMouseOver()
        {
            int flagCount = 0;
            if (Input.GetMouseButtonUp(1))
            {
                unit.Flag.enabled = !unit.Flag.enabled;
                hasFlag = !hasFlag;
                
                FlagCount(flagCount);
            }
        }

        
        private void FlagCount(int flagCount)
        {
            foreach (var tile in GridManager.Instance.Tiles)
            {
                Unit unit = tile.GetComponent<Unit>();

                if (unit.Flag.enabled)
                {
                    flagCount++;
                }
            }
            OnFlagCountChanged?.Invoke(this, flagCount);
        }


        private bool GetUnitHasFlag()
        {
            return hasFlag;
        }

    }
}
