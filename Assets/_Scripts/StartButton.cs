using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class StartButton : MonoBehaviour
    {
        [SerializeField] private Button startButton;
        [SerializeField] private Transform menuGameObject;
        [SerializeField] private Transform inGameObject;


        private void Start()
        {
            startButton.onClick.AddListener(() =>
                GameController.Instance.StartGame()
                );
            
            startButton.onClick.AddListener(() =>
                menuGameObject.gameObject.SetActive(false)
                );
            
            startButton.onClick.AddListener(() =>
                inGameObject.gameObject.SetActive(true)
                );
        }
    }
}