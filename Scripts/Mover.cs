using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.right);
    }
}
