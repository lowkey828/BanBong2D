using UnityEngine;

public class DestroyMuiTen : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("MuiTen"))
        {
            Destroy(collision.gameObject);
        }
    }
}
