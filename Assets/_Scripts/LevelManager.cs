using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts
{
    public class LevelManager : MonoBehaviour
    {
        public static LevelManager Instance { get; private set; }
        
        
        [SerializeField] private Transform x3GameObject;
        [SerializeField] private Transform x5GameObject;
        [SerializeField] private Transform x8GameObject;

        [SerializeField] private Button x3Button;
        [SerializeField] private Button x5Button;
        [SerializeField] private Button x8Button;
        
        
        private void Awake()
        {
            if (Instance != null)
            {
                Debug.LogError("There is a more than Level Manager!" + transform + "-" + Instance);
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }


        private void Start()
        {
            x3Button.onClick.AddListener((() => 
                ShowX3()));
            
            x5Button.onClick.AddListener((() => 
                ShowX5()));
            
            x8Button.onClick.AddListener((() => 
                ShowX8()));
        }


        public void ShowX3()
        {
            x3GameObject.gameObject.SetActive(true);
            HideX5();
            HideX8();
            SoundManager.Instance.OnClickButton();
        }
    
    
        public void ShowX5()
        {
            x5GameObject.gameObject.SetActive(true);
            HideX3();
            HideX8();
            SoundManager.Instance.OnClickButton();
        }
    
    
        public void ShowX8()
        {
            x8GameObject.gameObject.SetActive(true);
            HideX3();
            HideX5();
            SoundManager.Instance.OnClickButton();
        }
    
    
        public void HideX3()
        {
            x3GameObject.gameObject.SetActive(false);
        }
    
    
        public void HideX5()
        {
            x5GameObject.gameObject.SetActive(false);
        }
    
    
        public void HideX8()
        {
            x8GameObject.gameObject.SetActive(false);
        }
    }
}
