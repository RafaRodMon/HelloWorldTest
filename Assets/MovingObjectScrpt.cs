using UnityEngine;

public class MovingObjectScrpt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movingObject();
    }

    private void movingObject()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, 1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.Translate(0, -1, 0);
        }
    }
}
