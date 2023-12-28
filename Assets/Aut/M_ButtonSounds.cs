using UnityEngine;

namespace MT_Button
{
    [RequireComponent(typeof(AudioSource))]
    public class M_ButtonSounds : MonoBehaviour
    {
        /// <summary>
        /// 悬浮时音效
        /// </summary>
        public AudioClip hoverSound;
        /// <summary>
        /// 按下时音效
        /// </summary>
        public AudioClip pressedSound;
        private AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void PlayPressedSound()
        {
            audioSource.clip = pressedSound;
            audioSource.Play();
        }

        public void PlayHoverSound()
        {
            audioSource.clip = hoverSound;
            audioSource.Play();
        }
    }
}
