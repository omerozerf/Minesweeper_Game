using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class FlagCounter : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;


        private int flagCount;
        private int flagAmount;


        private void Start()
        {
            TouchManager.OnFlagCountChanged += TouchManager_OnFlagCountChanged;
            flagAmount = GameController.Instance.GetMineAmount();
        
            UpdateText();
        }


        private void Update()
        {
            UpdateText();
        }


        private void TouchManager_OnFlagCountChanged(object sender, int e)
        {
            flagCount = e;
        }


        private void OnDestroy()
        {
            TouchManager.OnFlagCountChanged -= TouchManager_OnFlagCountChanged;
        }


        private void UpdateText()
        {
            text.text = (flagAmount - flagCount).ToString();
        }
    }
}
