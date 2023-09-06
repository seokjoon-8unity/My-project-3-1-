using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TopDownCharaterController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; 
    public event Action<Vector2> OnLookEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}






//    //{
//    //    public float speed = 7f;
//    //    // Start is called before the first frame update
//    //    void Start()
//    //    {

//    //    }

//    //    // Update is called once per frame
//    void Update()
//    {

//        //        float x = Input.GetAxis("Horizontal");
//        //        float y = Input.GetAxis("Vertical");

//        //        transform.position += new Vector3(x, y) * speed * Time.deltaTime;
//    }
//}
