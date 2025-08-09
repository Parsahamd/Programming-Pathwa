using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    private Vector3 offset = new Vector3(0, 5, -9); // Offset from the player position

    public GameObject player; // Reference to the player GameObject
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
