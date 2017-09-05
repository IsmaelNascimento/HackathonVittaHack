using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace VittaHack.App
{
    public class ScreenStart : MonoBehaviour
    {
        [SerializeField]
        private InputField m_InputFieldCpf;
        [SerializeField]
        private List<string> m_Cpfs;
        private bool m_CpfValid = false;

        public void InputCpf(string inputCpf)
        {
            foreach (string cpf in m_Cpfs)
            {
                if(inputCpf == cpf)
                {
                    m_CpfValid = true;
                }
            }
        }

        public void OnEnterButtonClicked(string nameScene)
        {
            if (m_CpfValid)
            {
                SceneManager.LoadScene(nameScene);
                print("Cpf válido");
                m_CpfValid = false;
            }
            else
            {
                StartCoroutine(ErrorCpf_Coroutine());
                print("Cpf invalido");
            }
        }

        private IEnumerator ErrorCpf_Coroutine()
        {
            for (int i = 0; i < 3; i++)
            {
                m_InputFieldCpf.GetComponent<Image>().color = Color.red;
                yield return new WaitForSeconds(.1f);
                m_InputFieldCpf.GetComponent<Image>().color = Color.white;
                yield return new WaitForSeconds(.1f);
            }
        }

        public void OnAcessClinicWebButtonClicked()
        {
            Application.OpenURL("https://www.clinicweb.com.br/");
        }

        public void OnBackStartbButtonClicked(GameObject go)
        {
            go.SetActive(false);
        }

        public void OnSignupButtonClicked(GameObject go)
        {
            go.SetActive(true);
        }
    }
}