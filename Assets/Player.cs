using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedPlayer = 5f;
    public float speedMuiTen = 5f;
    public GameObject muiTenPrefab;
    public Transform attackArea;
    
    private Animator animator;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float inputVertical = Input.GetAxisRaw("Vertical");

        rb.linearVelocity = new Vector2(0, inputVertical * speedPlayer);

        if (inputVertical != 0)
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");

            GameObject muiTen = Instantiate(muiTenPrefab, attackArea.position, Quaternion.identity);
            
            Rigidbody2D rbMuiTen = muiTen.GetComponent<Rigidbody2D>();

            if (rbMuiTen != null)
            {
                rbMuiTen.linearVelocity = new Vector2(speedMuiTen, 0);
            }
        }
    }
}
