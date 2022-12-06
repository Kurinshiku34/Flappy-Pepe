using UnityEngine.UI;
using UnityEngine;

public class PhotoMove : MonoBehaviour {
    [SerializeField]private float speed=1;
    public Slider photo;
    private void Update() { if(photo.value == 100 || photo.value == 0) { speed *= -1; } photo.value += speed; } }
