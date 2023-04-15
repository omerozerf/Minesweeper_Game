using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class StartButton : MonoBehaviour
    {
        [SerializeField] private Button startButton;


        private void Start()
        {
            startButton.onClick.AddListener(() =>
                GameController.Instance.StartGame()
                );
        }
    }
}