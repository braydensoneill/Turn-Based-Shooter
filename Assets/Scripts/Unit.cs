using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition;
    [SerializeField] private float movementSpeed = 4f;
    private float stoppingDistance = 0.1f;

    private void Update() {
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            transform.position += moveDirection * movementSpeed * Time.deltaTime;
        }
        
        if(Input.GetKeyDown(KeyCode.T))
        {
            Move(new Vector3(4,0,4));
        }
    }

    private void Move(Vector3 _targetPosition) {
        this.targetPosition = _targetPosition;
    }
}
