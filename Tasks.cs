using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace VittaHack.App
{
    public class Tasks : MonoBehaviour
    {
        [Header("GameObjects")]
        [SerializeField]
        private Transform m_TaskParent;
        [SerializeField]
        private GameObject m_PrefabTask;

        [Header("Inputs")]
        [SerializeField]
        private InputField m_InputFieldNameTask;
        [SerializeField]
        private InputField m_InputFieldHoras;
        [SerializeField]
        private InputField m_InputFieldMinutes;
        private string m_NameTask;
        private string m_Horas;
        private string m_Minutes;

        public void GetNameTask(string nameTask)
        {
            m_NameTask = nameTask;
        }

        public void GetHoras(string horas)
        {
            m_Horas = horas;
        }

        public void GetMinutes(string minutes)
        {
            m_Minutes = minutes;
        }

        public void OpenScreenAddTask(GameObject screenTask)
        {
            screenTask.SetActive(true);
        }

        public void CanceledTask(GameObject screenTask)
        {
            screenTask.SetActive(false);
        }

        public void OnAddTaskButtonCliked(GameObject screenTask)
        {
            Transform newTask = Instantiate(m_PrefabTask, m_TaskParent).transform;

            newTask.GetChild(0).GetComponent<Text>().text = m_NameTask;
            newTask.GetChild(1).GetComponent<Text>().text = string.Format("Horário: {0}:{1}", m_Horas, m_Minutes);
            screenTask.SetActive(false);

            print("Added task");
        }

        public void GoScene(string nameScene)
        {            
            SceneManager.LoadScene(nameScene);
        }
    }
}