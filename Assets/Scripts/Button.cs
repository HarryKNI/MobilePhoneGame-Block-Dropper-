using UnityEngine;

public class Button : MonoBehaviour
{
    GameObject Blocker;
    public Animator anim;

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
        if (collision.gameObject.tag == "Button1")
        {
            Blocker = GameObject.Find("Blocker");
            //Blocker.SetActive(false);
            anim.SetBool("Button_Pressed", true);
            print("trigger works");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        //Blocker.SetActive(true);
        anim.SetBool("Button_Pressed", false);
    }
}
