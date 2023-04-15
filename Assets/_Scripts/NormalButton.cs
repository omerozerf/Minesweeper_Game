using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class NormalButton : MonoBehaviour
    {
        [SerializeField] private Button normalButton;


        private void Start()
        {
            normalButton.onClick.AddListener(() => 
                GameController.Instance.SetMineAmount(5)
            );
        }
    }
}