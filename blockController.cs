using UnityEngine;

public class blockController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    int key = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * key, 0, 0);
        if(transform.position.x < -4.5f) key = 1;
        if(transform.position.x > 4.5f) key = -1;
    }
}
