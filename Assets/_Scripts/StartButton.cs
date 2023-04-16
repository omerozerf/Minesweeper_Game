using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class StartButton : MonoBehaviour
    {
        public static StartButton Instance { get; private set; }
        
        
        [SerializeField] private Button startButton;
        [SerializeField] private Transform menuGameObject;
        [SerializeField] private Transform inGameObject;


        public bool isStart;
        
        
        private void Awake()
        {
            if (Instance != null)
            {
                Debug.LogError("There is a more than Start Button!" + transform + "-" + Instance);
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }
        

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
            
            startButton.onClick.AddListener((() => 
                isStart = true
                ));
            
            startButton.onClick.AddListener((() => 
                    SoundManager.Instance.OnClickButton()
                ));
        }
    }
}