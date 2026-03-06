using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola mi nombre es: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola mi nombre es: " + gameObject.name);
    }
}
