using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboTransformer : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        transform.localScale += transform.localScale * _scaleSpeed * Time.deltaTime;
    }
}
