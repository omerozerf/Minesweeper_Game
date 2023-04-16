using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class EasyButton : MonoBehaviour
    {
        public GameDifficulty gameDifficulty;
        
        
        [SerializeField] private Button easyButton;


        private void Start()
        {
            easyButton.onClick.AddListener(() => 
                GameController.Instance.SetMineAmount(3)
                );
            
            easyButton.onClick.AddListener(() => 
                gameDifficulty = GameDifficulty.Easy
                );
            
            easyButton.onClick.AddListener((() => 
                    SoundManager.Instance.OnClickButton()
                ));
        }
    }
}