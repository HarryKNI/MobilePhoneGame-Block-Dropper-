using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private Rigidbody rigid;
    public float movement;
    private bool right;
    private bool left;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        movement = 10f;
        
        Input.gyro.enabled = true;

        //right = false;
        //left = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Quaternion Rotation = Quaternion.identity;
        Quaternion DeviceRotation = new Quaternion(0.5f, 0.5f, -0.5f, 0.5f) * Input.gyro.attitude * new Quaternion(0, 0, 1, 0);

        print(DeviceRotation);

        if (DeviceRotation.x <= 0.5000f && DeviceRotation.x > 0.0f)
        {
            print("stopped");
        }

        if (DeviceRotation.x < -0.2000f)
        {
            rigid.linearVelocity = new Vector2(movement, 0f);
            
        }

        if (DeviceRotation.x > 0.2000f && DeviceRotation.x < 0.5000)
        {
            rigid.linearVelocity = new Vector2(-movement, 0f);
            
        }

    }



}
