using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    public GameObject Settings;
    public GameObject Menu;
    public GameObject Volume;
    
    public float VolumeLevel;
    public float VolumeSet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    void Start()
    {
        
        VolumeSet = PlayerPrefs.GetFloat("Music_volume");
        Volume.GetComponent<Slider>().value = VolumeSet;

    }

    // Update is called once per frame
    void Update()
    {
        //print(PlayerPrefs.HasKey("Music_volume"));
        //print("Volume Set " + VolumeSet);
        //print("Volume Level " + VolumeLevel); 
    }

    public void SceneLoader(int SceneNum)
    {
        SceneManager.LoadScene(SceneNum);
        Time.timeScale = 1.0f;
    }

    public void ToggleMenu()
    {
        Menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeButton()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void SettingsMenu()
    {
        Settings.SetActive(true);
        Menu.SetActive(false);
    }

    public void MainSettingsMenu()
    {
        Settings.SetActive(true);
    }

    public void Back()
    {
        Settings.SetActive(false);
        Menu.SetActive(true);
        Time.timeScale = 1;
    }

    public void VolumeSlider()
    {
        VolumeLevel = Volume.GetComponent<Slider>().value; 
        PlayerPrefs.SetFloat("Music_volume", VolumeLevel);
        PlayerPrefs.Save();

    }

    public void QuitGame()
    {
        Application.Quit();
    }






    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

  
}
