using UnityEngine;

public class MuiTen : MonoBehaviour
{
    public GameObject boom;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Vector2 diemVaCham = collision.contacts[0].point;

            GameObject hieuUngNo = Instantiate(boom, diemVaCham, Quaternion.identity);

            Destroy(collision.gameObject);
            Destroy(gameObject);
            Destroy(hieuUngNo, 0.5f);
        }
    }
}
