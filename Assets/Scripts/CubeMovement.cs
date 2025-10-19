using UnityEngine;

public class CubeMovement : MonoBehaviour  
{
    public bool isFlat = true;
    private Rigidbody rigid;
    public Vector3 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        movement.x = 1;
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion tilt = Input.gyro.attitude;

        //if (isFlat)
        //    tilt = Quaternion.Euler(90, 0, 0) * tilt;

        float newmovement = tilt.y + movement.x;

        transform.position = new Vector3(newmovement, 0, 0);

        //print(tilt);
    }

    public void test()
    {

    }
}
