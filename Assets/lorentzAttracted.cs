using UnityEngine;

public class lorentzAttracted : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var p = this.transform.position;
        float dx = 0.1f * Time.deltaTime * (10 * (p.y - p.x));
        float dy = 0.1f * Time.deltaTime * (p.x * (28 - p.z) - p.y);
        float dz = 0.1f * Time.deltaTime * (p.x * p.y - 2.66f * p.z);

        this.transform.Translate(dx, dy, dz, Space.World);
    }
}
