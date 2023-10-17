using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{

    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.localScale += transform.localScale * _scaleSpeed * Time.deltaTime;

    }
}
