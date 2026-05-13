using UnityEngine;

public class PlayerSeaQuest : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, y, 0.0f);

        if(GameManager.air <= 0)
        {
            GameManager.inWater = false;
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //print(collision.gameObject.name);

        if(collision.gameObject.tag == "Water")
        {
           GameManager.inWater = true;
        }
        else if(collision.gameObject.tag == "Air")
        {
            GameManager.air = 100;
            GameManager.inWater = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            GameManager.score++;
        }
    }
}
