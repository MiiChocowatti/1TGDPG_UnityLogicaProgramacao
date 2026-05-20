using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private string inputName;

    private void Update()
    {
        float x = Input.GetAxisRaw(inputName) * speed * Time.deltaTime;
        transform.Translate(x, 0.0f, 0.0f);
    }
}
