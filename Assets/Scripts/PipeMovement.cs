using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 3f;
    private float boundary;
    private void Start() { boundary = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 5f; }
    private void Update() { transform.position += Vector3.left * speed * Time.deltaTime; if (transform.position.x < boundary) { Destroy(gameObject); } }
}
