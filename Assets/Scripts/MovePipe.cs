using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private float PipeSpeed = .65f;

    private void Update()
    {
        transform.position += Vector3.left * PipeSpeed * Time.deltaTime;
    }
}
