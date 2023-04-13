using UnityEngine;

namespace _Scripts
{
    public class TouchController : MonoBehaviour
    {
        [SerializeField] private Unit unit;
        
        
        private void OnMouseDown()
        {
            
        }


        private void OnMouseUp()
        {
            unit.Mask.enabled = false;
        }
    }
}
