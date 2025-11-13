using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public GameObject Player;

    private float MovementSpeed = 1.0f;
    
    bool Up;
    bool Down;
    bool right;
    bool left;

    Vector3 MovementDirection;

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
            transform.position = new Vector3(0f, 0f, MovementSpeed);
            Player.transform.Translate(transform.position);
            Player.transform.rotation = Quaternion.LookRotation(MovementDirection);
        }

        if (Up == true)
        {
            transform.position = new Vector3(0f, 0f, MovementSpeed);
            Player.transform.Translate(transform.position);
            Player.transform.rotation = Quaternion.LookRotation(MovementDirection);
        }

        if (right == true)
        {
            transform.position = new Vector3(0f, 0f, MovementSpeed);
            Player.transform.Translate(transform.position);
            Player.transform.rotation = Quaternion.LookRotation(MovementDirection);
        }

        if (left == true)
        {
            transform.position = new Vector3(0f, 0f, MovementSpeed);
            Player.transform.Translate(transform.position);
            Player.transform.rotation = Quaternion.LookRotation(MovementDirection);
        }
    }

    public void UpMovementDOWN()
    {
        Up = true;
        MovementDirection = Vector3.forward;
    }

    public void UpMovementUP()
    {
        Up = false;
        MovementDirection = Vector3.zero;
    }

    public void DownMovementDOWN()
    {
        Down = true;
        MovementDirection = Vector3.back;


    }

    public void DownMovementUP()
    {
        Down = false;
        MovementDirection = Vector3.zero;
    }

    public void LeftMovementDOWN()
    {
        left = true;
        MovementDirection = Vector3.left;
    }

    public void LeftMovementUP()
    {
        left = false;
        MovementDirection = Vector3.zero;
    }

    public void RightMovementDOWN()
    {
        right = true;
        MovementDirection = Vector3.right;
    }

    public void RightMovementUP()
    {
        right = false;
        MovementDirection = Vector3.zero;
    }
}
