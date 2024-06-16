using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanScript : MonoBehaviour
{
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    animator.SetBool("mode", true);
        //}
        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    animator.SetBool("mode", false);
        //}

        
        if (Input.GetKey(KeyCode.UpArrow)||Input.GetButton("Jump"))
        {
            Vector3 velocity = new Vector3(0, 0, 1.0f);
            transform.position += transform.rotation * velocity*Time.deltaTime;
            animator.SetBool("mode", true);
        }
        else
        {
            animator.SetBool("mode", false);
        }
        float stick = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.RightArrow)||stick>0)
        {
            Vector3 worldAngle = transform.eulerAngles;
            worldAngle.y += 1.0f;

            transform.eulerAngles = worldAngle;
        }
        if (Input.GetKey(KeyCode.LeftArrow)||stick<0)
        {
            Vector3 worldAngle = transform.eulerAngles;
            worldAngle.y -= 1.0f;

            transform.eulerAngles = worldAngle;
        }
    }
}
