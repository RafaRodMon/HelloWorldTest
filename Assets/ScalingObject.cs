using UnityEngine;

public class ScalingObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scaling();
    }

    public void Scaling()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.localScale -= Vector3.right * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            transform.localScale = Vector3.up * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            transform.localScale = Vector3.down * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.localScale = Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.localScale = Vector3.back * Time.deltaTime;
        }
    }
}