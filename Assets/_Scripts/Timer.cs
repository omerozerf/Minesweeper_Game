using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts
{
    public class Timer : MonoBehaviour
    {
        [FormerlySerializedAs("bestScore")] public int bestTime;


        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private TextMeshProUGUI bestTimeText;
        


        private float currentTime;


        private void Start()
        {
            bestTime = PlayerPrefs.GetInt("BestScore", 0);
            bestTimeText.text = "Best Time:" + bestTime;
        }

        private void Update()
        {
            if (GameController.Instance.isFinish ||
                GameController.Instance.isGameWin) return;
            
            currentTime += Time.deltaTime;
            text.text = currentTime.ToString("0000");

            if (currentTime < bestTime && GameController.Instance.isGameWin)
            {
                bestTime = (int) currentTime;
                PlayerPrefs.SetInt("BestScore", bestTime);
            }

        }
    }
}
