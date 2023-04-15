using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class HardButton : MonoBehaviour
    {
        [SerializeField] private Button hardButton;


        private void Start()
        {
            hardButton.onClick.AddListener(() => 
                GameController.Instance.SetMineAmount(10)
            );
        }
    }
}