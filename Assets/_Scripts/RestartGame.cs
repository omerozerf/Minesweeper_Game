using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    [SerializeField] private Button restartGameButton;


    private const string GAME_SCENE = "_Scenes/GameScene";
    
    
    private void Start()
    {
        restartGameButton.onClick.AddListener((() => 
                SoundManager.Instance.OnClickButton()
            ));
        
        restartGameButton.onClick.AddListener((() => 
                SceneManager.LoadScene(GAME_SCENE)));
    }
}
