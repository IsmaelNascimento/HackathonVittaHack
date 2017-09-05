using UnityEngine;
using UnityEngine.UI;

namespace VittaHack.App
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private Slider m_Life;
        [SerializeField]
        private Slider m_LifeCount;
        [SerializeField]
        private ParticleSystem m_ParticleSystemGood;
        [SerializeField]
        private ParticleSystem m_ParticleSystemBad;

        private void Start()
        {
            Screen.orientation = ScreenOrientation.Landscape;
        }

        public void ClickOK()
        {
            m_Life.value += 0.05f;
            m_LifeCount.value += 0.01f;
            m_ParticleSystemGood.Play();
        }

        public void ClickNegativo()
        {
            m_Life.value -= 0.05f;
            m_LifeCount.value -= 0.01f;
            m_ParticleSystemBad.Play();
        }

        public void activeDeactive(GameObject obj)
        {
            if (obj.activeSelf)
                obj.SetActive(false);
            else obj.SetActive(true);
        }
    }
}