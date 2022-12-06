using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private Material mat;
    private float distance;
    public float speed = 0.133f;

    void Start(){ mat = GetComponent<Renderer>().material; }

    void Update() { distance += Time.deltaTime * speed; mat.SetTextureOffset("_MainTex", Vector2.right * distance); }
}
