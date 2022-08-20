using UnityEngine;

public class stvaranjeStvari : MonoBehaviour
{
    public float scrollSpeed;
    public float tileWidth;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position -= Time.deltaTime * scrollSpeed * Vector3.right * Mathf.Min(1+Time.time/20f, 2);
        if (transform.position.x < -130)
        {
            transform.position = new Vector3(Random.Range(250,400), Random.Range(-50, 80), transform.position.z);
        }
        //float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileWidth);
        //transform.position = startPosition + Vector3.left * newPosition;
    }
}
