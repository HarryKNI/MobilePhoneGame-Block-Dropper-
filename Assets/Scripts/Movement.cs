using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public GameObject Player;

    private float MovementSpeed = 0.01f;
    
    bool Up;
    bool Down;
    bool right;
    bool left;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Player = GameObject.Find("Player");

        Down = false;
        Up = false;
        left = false;
        right = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Down == true)
        {
            transform.position = new Vector3(0f, 0f, -MovementSpeed);
            Player.transform.Translate(transform.position);
        }

        if (Up == true)
        {
            transform.position = new Vector3(0f, 0f, MovementSpeed);
            Player.transform.Translate(transform.position);
        }

        if (right == true)
        {
            transform.position = new Vector3(MovementSpeed, 0f, 0f);
            Player.transform.Translate(transform.position);
        }

        if (left == true)
        {
            transform.position = new Vector3(-MovementSpeed, 0f, 0f);
            Player.transform.Translate(transform.position);
        }
    }

    public void UpMovementDOWN()
    {
        Up = true;
    }

    public void UpMovementUP()
    {
        Up = false;
    }

    public void DownMovementDOWN()
    {
        Down = true;

    }

    public void DownMovementUP()
    {
        Down = false;
    }

    public void LeftMovementDOWN()
    {
        left = true;
    }

    public void LeftMovementUP()
    {
        left = false;
    }

    public void RightMovementDOWN()
    {
        right = true;
    }

    public void RightMovementUP()
    {
        right = false;
    }
}
