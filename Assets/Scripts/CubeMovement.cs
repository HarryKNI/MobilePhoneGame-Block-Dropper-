using UnityEngine;

public class CubeMovement : MonoBehaviour  
{
    public bool isFlat = true;
    private Rigidbody rigid;
    public float movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        movement = 20f;
        
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion Rotation = Quaternion.identity;
        Quaternion DeviceRotation = new Quaternion(0.5f, 0.5f, -0.5f, 0.5f) * Input.gyro.attitude * new Quaternion(0, 0, 1, 0);
        //Quaternion tilt = Input.gyro.attitude;

        float newmovement = DeviceRotation.x * movement;

        rigid.linearVelocity = new Vector2(newmovement, 0f);

    }

    public void test()
    {

    }
}
