using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;


        private float time = 0f;
        
        
        private void Update()
        {
            if (GameController.Instance.isFinish) return;
            
            time += Time.deltaTime;
            text.text = time.ToString("0000");
        }
    }
}
