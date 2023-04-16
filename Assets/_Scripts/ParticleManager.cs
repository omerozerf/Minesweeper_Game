using System;
using UnityEngine;

namespace _Scripts
{
    public class ParticleManager : MonoBehaviour
    {
        public static ParticleManager Instance;
    
        [SerializeField] private ParticleSystem boomParticleSystem;


        private void Awake()
        {
            Instance = this;
        }


        public void TriggerParticleEffect()
        {
            boomParticleSystem.Play();
            Debug.Log("boooooom");
        }
    }
}

