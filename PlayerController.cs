using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float walkSpeed = 0.1f;
    [SerializeField] float jumpForce = 0.1f;
    Rigidbody2D rb;
    bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //左右移動
        float key = 0;
        if(Input.GetKey(KeyCode.A))
        {
            key = -1;
        }

        if(Input.GetKey(KeyCode.D))
        {
            key = 1;
        }

        rb.linearVelocity = new Vector2(key * walkSpeed, rb.linearVelocity.y);
    }

    void FixedUpdate()
    {
        //ジャンプ
        if(isGrounded)
        {
            // 上方向に速度を上書きする（AddForceよりもキビキビ動く）
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false; // ジャンプしたのでフラグを下ろす
        }
        // //左右移動
        // if(Input.GetKey(KeyCode.A))
        // {
        //     rb.linearVelocity = transform.right * -walkSpeed;
        // }
        // if(Input.GetKey(KeyCode.D))
        // {
        //     rb.linearVelocity = transform.right * walkSpeed;
        // }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}
