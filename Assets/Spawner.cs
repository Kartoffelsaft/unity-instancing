using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject what;
    public int count;
    public Bounds area;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < count; i++) {
            var pos = new Vector3(
                Random.Range(area.min.x, area.max.x),
                Random.Range(area.min.y, area.max.y),
                Random.Range(area.min.z, area.max.z)
            );

            var obj = Instantiate(what, pos, Random.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
