using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speedX;
    [SerializeField] private float speedY;

    private float speedCurrentX;
    private float speedCurrentY;

    void Start()
    {
        speedCurrentX = speedX;
        speedCurrentY = speedY;
    }

    void Update()
    {
        transform.Translate(speedCurrentX * Time.deltaTime, speedCurrentY * Time.deltaTime, 0.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WallX")
        {
            speedCurrentX *= -1;
        }
        if (collision.gameObject.tag == "WallY")
        {
            speedCurrentY *= -1;
        }
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.tag == "left")
        {
            speedCurrentX = -speedX;
        }
        else if (collision.tag == "center")
        {
            speedCurrentX = 0.0f;
        }
        else if (collision.tag == "right")
        {
            speedCurrentX = speedX;
        }
    }
}
