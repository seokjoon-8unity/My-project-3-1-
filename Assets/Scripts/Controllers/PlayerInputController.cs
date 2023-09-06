using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharaterController
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        //Debug.Log("OnMove" +  value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        //Debug.Log("OnLook" + value.ToString());
        Vector2 newaim = value.Get<Vector2>();
        Vector2 worldpos = _camera.ScreenToWorldPoint(newaim);
        newaim = worldpos - (Vector2)transform.position.normalized;

        if (newaim.magnitude >= .9f)
        {
            CallLookEvent(newaim);
        } 


    }

    public void OnFire(InputValue value)
    {
        //Debug.Log("OnFire" + value.ToString());

    }
}
