using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpMovement()
    {
        transform.position = new Vector3(0f,0f,0.5f);
        Player.transform.Translate(transform.position);
    }

    public void DownMovement()
    {
        transform.position = new Vector3(0f, 0f, -0.5f);
        Player.transform.Translate(transform.position);
    }

    public void LeftMovement()
    {
        transform.position = new Vector3(-0.5f, 0f, 0.5f);
        Player.transform.Translate(transform.position);
    }

    public void RightMovement()
    {
        transform.position = new Vector3(0.5f, 0f, 0f);
        Player.transform.Translate(transform.position);
    }
}
