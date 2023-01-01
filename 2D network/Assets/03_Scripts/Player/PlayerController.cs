using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isMove;

    [SerializeField] private float speed = 2f;

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        if (isMove)
        {
            Vector3 dir = Vector3.ClampMagnitude(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f), 1f);
            if (dir.x < 0f) transform.localScale = new Vector3(-0.5f, 0.5f, 1f);
            else if (dir.x > 0f) transform.localScale = new Vector3(0.5f, 0.5f, 1f);

            transform.position += dir * speed * Time.deltaTime;
        }
    }
}
