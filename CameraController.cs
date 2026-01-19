using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    float playerY = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        playerY = Mathf.Max(playerPos.y, playerY);
        transform.position = new Vector3(transform.position.x, playerY, transform.position.z);
    }
}
