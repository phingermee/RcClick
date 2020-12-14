using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMan : MonoBehaviour
{

    [SerializeField] private float _speed;
    private Vector3 _direction;
    private float _lifetime = 2.2f;

    private void Start()
    {
        ChooseDirection(ref _direction);
        Destroy(this.gameObject, _lifetime);
    }

    private void ChooseDirection(ref Vector3 direction)
    {
        if (Random.Range(0, 100) % 2 == 0)
        {
            direction = Vector3.right;
        }
        else
        {
            direction = Vector3.left;
        }
    }

    private void MoveMan()
    {
        transform.position += _direction * _speed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        MoveMan();
    }
}
