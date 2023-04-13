using UnityEngine;

namespace _Scripts
{
    public class TouchController : MonoBehaviour
    {
        [SerializeField] private Unit unit;
        
        
        private void OnMouseDown()
        {
            Debug.Log("On Mouse Down!");
        }


        private void OnMouseUp()
        {
            Debug.Log("On Mouse Up!");
            unit.Mask.enabled = false;
        }
    }
}
