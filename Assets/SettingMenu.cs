using UnityEngine;
using UnityEngine.SceneManagement;


public class SettingMenu : MonoBehaviour
{
    [SerializeField] GameObject setting;
    void Settingb()
    {
        setting.SetActive(true);
    }
    void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    void Resume()
    {
        setting.SetActive(false);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    void Music()
    {

    }

    void Information()
    {
        SceneManager.LoadScene("Information");
    }

}
