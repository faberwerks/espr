using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject goal;
    public bool isInteracting;
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        isInteracting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(goal != null)
        {
            isInteracting = true;
            transform.position = Vector3.MoveTowards(transform.position, goal.transform.position, speed * Time.deltaTime);
        }

        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            goal = null;
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            isInteracting = false;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            goal = null;
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            isInteracting = false;
        }
    }

    
}
