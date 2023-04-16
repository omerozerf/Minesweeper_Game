using UnityEngine;

namespace _Scripts
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance { get; private set; }


        [SerializeField] private AudioSource audioSource;
    
        [SerializeField] private AudioClip buttonClickAudioClip;
        [SerializeField] private AudioClip bombAudioClip;
        [SerializeField] private AudioClip flaggedAudioClip;
        [SerializeField] private AudioClip tileOpenAudioClip;
        [SerializeField] private AudioClip warningAudioClip;
        [SerializeField] private AudioClip unFlaggedAudioClip;
        

        private void Awake()
        {
            if (Instance != null)
            {
                Debug.LogError("There is a more than Sound Manager!" + transform + "-" + Instance);
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }
    

        public void OnClickButton()
        {
            audioSource.clip = buttonClickAudioClip;
            audioSource.Play();
        }
    
    
        public void OnClickBomb()
        {
            audioSource.clip = bombAudioClip;
            audioSource.Play();
        }
    
    
        public void OnFlagged()
        {
            audioSource.clip = flaggedAudioClip;
            audioSource.Play();
        }
    
    
        public void OnClickTile()
        {
            audioSource.clip = tileOpenAudioClip;
            audioSource.Play();
        }
    
    
        public void Warning()
        {
            audioSource.clip = warningAudioClip;
            audioSource.Play();
        }
        
        
        public void OnUnFlagged()
        {
            audioSource.clip = unFlaggedAudioClip;
            audioSource.Play();
        }
    }
}
