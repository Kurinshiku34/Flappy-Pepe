using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1f;
    private float timer = 0f;
    public GameObject pipes;
    public float height;

    private void Start()
    {
        GameObject newpipes = Instantiate(pipes);
        newpipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    private void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipes = Instantiate(pipes);
            newpipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            timer = 0f;
        }
        timer += Time.deltaTime;
    }
}
