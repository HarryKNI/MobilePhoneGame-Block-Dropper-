using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Fail : MonoBehaviour
{

    public GameObject Resume_button;
    public GameObject Settings_button;
    public GameObject Menu_button;
    public GameObject Quit_button;
    public GameObject DeathScreen;
    public GameObject Menu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Death_Box")
        {
            print("Working");
            Time.timeScale = 0;
            Menu.SetActive(true);
            Quit_button.SetActive(false);
            Resume_button.SetActive(false);
            Settings_button.SetActive(false);
            Menu_button.SetActive(false);
            DeathScreen.SetActive(true);

        }
    }
}
