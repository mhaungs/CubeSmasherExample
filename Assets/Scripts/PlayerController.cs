using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;

    InputAction _moveAction;

    void Start()
    {
        _moveAction = InputSystem.actions.FindAction("HMove");
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float moveDistance = _moveAction.ReadValue<float>();
        Vector3 newPosition = transform.position + new Vector3(moveDistance * speed * Time.deltaTime, 0, 0);
        newPosition.x = Mathf.Clamp(newPosition.x, -4.5f, 4.5f);
        transform.position = newPosition;   
    }
}
