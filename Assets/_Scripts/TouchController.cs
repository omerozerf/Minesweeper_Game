using System;
using UnityEngine;

namespace _Scripts
{
    public class TouchController : MonoBehaviour
    {
        [SerializeField] private Unit unit;


        private bool hasFlag = false;
        
        
        private void OnMouseUp()
        {
            unit.Mask.enabled = false;
        }


        private void OnMouseOver()
        {
            if (Input.GetMouseButtonUp(1))
            {
                unit.Flag.enabled = !unit.Flag.enabled;
                hasFlag = !hasFlag;
                
                Debug.Log(hasFlag);
            }
        }
    }
}
