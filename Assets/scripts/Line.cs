using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    float xDirection; //huong di chuyen (trai hoac phai)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //khi bam nut sang trai thi no tra va la  -1, khi bam sang phai tra ve 1
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        if(transform.position.x <=-6.8f && xDirection < 0 || transform.position.x>=6.78f && xDirection >0)
        {
            return;
        }
        transform.position += new Vector3(moveStep,0,0);
    }
}
