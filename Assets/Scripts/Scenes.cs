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
        // wont load volume set on main scene
        //Settings = GameObject.Find("Settings");
        //Menu = GameObject.Find("Menu");
        //Volume = GameObject.Find("Volume_Bar");
        
        //Settings.SetActive(false);
        //Menu.SetActive(false);
        
        VolumeSet = PlayerPrefs.GetFloat("Music_volume");
        Volume.GetComponent<Slider>().value = VolumeSet;

    }

    // Update is called once per frame
    void Update()
    {
        print(PlayerPrefs.HasKey("Music_volume"));
        print("Volume Set " + VolumeSet);
        print("Volume Level " + VolumeLevel); 
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Level1Scene()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ToggleMenu()
    {
        Menu.SetActive(true);
    }

    public void ResumeButton()
    {
        Menu.SetActive(false);
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
    }

    public void VolumeSlider()
    {
        VolumeLevel = Volume.GetComponent<Slider>().value; 
        PlayerPrefs.SetFloat("Music_volume", VolumeLevel);
        PlayerPrefs.Save();

    }

    

    


    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

  
}
