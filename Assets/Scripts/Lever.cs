using UnityEngine;

public class Lever : MonoBehaviour
{

    public Animator LeverMove;
    public Animator DoorMove;
    public GameObject Door;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LeverMove.Play("LeverMove");
            DoorMove.Play("DoorMove");
            Door.SetActive(false);

        }
    }

}
