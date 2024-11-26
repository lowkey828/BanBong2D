using System.Collections;
using System.Xml.Schema;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject[] balls;
    public int xMin = -5, xMax = 5;
    public float minSpeed = 5f, maxSpeed = 10f;
    public int yStart = -10;

    void Start()
    {
        StartCoroutine(HandleBall());
    }

    IEnumerator HandleBall()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, balls.Length);
            GameObject randomBall = balls[randomIndex];

            int randomX = Random.Range(xMin, xMax);
            Vector3 viTriNgauNhien = new Vector3(randomX, yStart, 0);

            GameObject newBall = Instantiate(randomBall, viTriNgauNhien, Quaternion.identity);

            Rigidbody2D rb = newBall.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                float randomSpeed = Random.Range(minSpeed, maxSpeed);

                rb.linearVelocity = randomSpeed * Vector2.up;
            }

            yield return new WaitForSeconds(2);
        }
    }
}
