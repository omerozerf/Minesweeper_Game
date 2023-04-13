using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;


        private void Update()
        {
            int timer = (int)Time.deltaTime;
            Debug.Log(timer);
        }


    
    }
}
