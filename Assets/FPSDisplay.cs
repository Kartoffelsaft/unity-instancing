using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    Text output;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        output = GetComponent<Text>();
        output.text = "Loading";
    }

    // Update is called once per frame
    void Update()
    {
        output.text = string.Format("{0} FPS", 1.0f / Time.deltaTime);
    }
}
