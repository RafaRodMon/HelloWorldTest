using System.Xml.Serialization;
using UnityEngine;

public class ScriptingTracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject TrackedObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PositionLogTrace();
    }

    private void PositionLogTrace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float positionX = TrackedObject.transform.position.x;
            float positionY = TrackedObject.transform.position.y;
            float positionZ = TrackedObject.transform.position.z;

            Debug.Log("The tracked object is: " + TrackedObject.name + " My x is: " + positionX);
            Debug.Log("The tracked object is: " + TrackedObject.name + " My x is: " + positionY);
            Debug.Log("The tracked object is: " + TrackedObject.name + " My x is: " + positionZ);
        }
    }
}
