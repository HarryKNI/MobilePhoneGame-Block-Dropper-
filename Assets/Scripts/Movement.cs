using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public GameObject Player;
    public Camera Camera;
    public Animator Anim;

    Vector3 PlayerMovement;
    private float MovementSpeed = 5.0f;

    
    bool Up;
    bool Down;
    bool right;
    bool left;

    Vector3 MovementDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
            PlayerMovement = new Vector3(0f, 0f, MovementSpeed * Time.deltaTime);
            Player.transform.Translate(PlayerMovement);
            Player.transform.rotation = Quaternion.LookRotation(MovementDirection);
            

        }

        if (Up == true)
        {
            PlayerMovement = new Vector3(0f, 0f, MovementSpeed * Time.deltaTime);
            Player.transform.Translate(PlayerMovement);
            Player.transform.rotation = Quaternion.LookRotation(MovementDirection);
            

        }

        if (right == true)
        {
            PlayerMovement = new Vector3(0f, 0f, MovementSpeed * Time.deltaTime);
            Player.transform.Translate(PlayerMovement);
            Player.transform.rotation = Quaternion.LookRotation(MovementDirection);
            Camera.transform.Translate(1f * Time.deltaTime, 0f, 0f);
            
        }

        if (left == true)
        {
            PlayerMovement = new Vector3(0f, 0f, MovementSpeed * Time.deltaTime);
            Player.transform.Translate(PlayerMovement);
            Player.transform.rotation = Quaternion.LookRotation(MovementDirection);
            Camera.transform.Translate(-1f * Time.deltaTime, 0f, 0f);
            
        }
    }

    public void UpMovementDOWN()
    {
        Up = true;
        MovementDirection = Vector3.forward;
        Anim.SetBool("IsWalking", true);
    }

    public void UpMovementUP()
    {
        Up = false;
        MovementDirection = Vector3.zero;
        Anim.SetBool("IsWalking", false);
    }

    public void DownMovementDOWN()
    {
        Down = true;
        MovementDirection = Vector3.back;
        Anim.SetBool("IsWalking", true);
    }

    public void DownMovementUP()
    {
        Down = false;
        MovementDirection = Vector3.zero;
        Anim.SetBool("IsWalking", false);
    }

    public void LeftMovementDOWN()
    {
        left = true;
        MovementDirection = Vector3.left;
        Anim.SetBool("IsWalking", true);
    }

    public void LeftMovementUP()
    {
        left = false;
        MovementDirection = Vector3.zero;
        Anim.SetBool("IsWalking", false);
    }

    public void RightMovementDOWN()
    {
        right = true;
        MovementDirection = Vector3.right;
        Anim.SetBool("IsWalking", true);
    }

    public void RightMovementUP()
    {
        right = false;
        MovementDirection = Vector3.zero;
        Anim.SetBool("IsWalking", false);
    }
}
