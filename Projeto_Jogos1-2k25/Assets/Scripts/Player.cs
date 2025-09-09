using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;
    
    private Rigidbody2D rigid;
    public float speed;

    public float jumpforce = 5f;
    public bool isground;    
    
    void Start()
    {
        anim=GetComponent<Animator>();
        rigid=GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Move();
        Jump();
    }
    
    void Move()
    {
        float teclas = Input.GetAxis("Horizontal");
        rigid.linearVelocity = new Vector2(teclas * speed, rigid.linearVelocity.y);
        if (teclas > 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0, 0);
            anim.SetInteger("transition", 1);

        }
        if (teclas < 0 && isground == true)
        {
            transform.eulerAngles = new Vector2(0, 180);
            anim.SetInteger("transition", 1);

        }
        if (teclas == 0 && isground == true)
        {
            anim.SetInteger("transition", 0);
        }

    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && isground==true)
        {
            rigid.AddForce(Vector2.up * jumpforce,ForceMode2D.Impulse);
            anim.SetInteger("transition", 2);
            isground = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="tagGround")
        {
            isground = true;
            Debug.Log("esta no chão,2");
        }
    }

}
