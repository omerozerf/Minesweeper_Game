using System;
using UnityEngine;

namespace _Scripts
{
    public class TouchManager : MonoBehaviour
    {
        [SerializeField] private Unit unit;


        private bool hasFlag = false;
        
        
        private void OnMouseUp()
        {
            if (!GetUnitHasFlag())
            {
                unit.Mask.enabled = false;
            }
        }


        private void OnMouseOver()
        {
            if (Input.GetMouseButtonUp(1))
            {
                unit.Flag.enabled = !unit.Flag.enabled;
                hasFlag = !hasFlag;
            }
        }


        private bool GetUnitHasFlag()
        {
            return hasFlag;
        }
    }
}
