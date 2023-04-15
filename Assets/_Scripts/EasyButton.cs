using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class EasyButton : MonoBehaviour
    {
        [SerializeField] private Button easyButton;


        private void Start()
        {
            easyButton.onClick.AddListener(() => 
                GameController.Instance.SetMineAmount(3)
                );
        }
    }
}