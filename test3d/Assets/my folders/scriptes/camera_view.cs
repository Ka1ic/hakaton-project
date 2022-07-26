using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_view : MonoBehaviour
{
    [SerializeField] private float step = 5;

    private float value = 0;

    void Update()
    {
        transform.Rotate(0, value / 10, 0);
    }

    public void rotateRight()
    {
        value -= step;
    }

    public void rotateLeft()
    {
        value += step;
    }

    public void stopRotate()
    {
        value = 0;
    }
}
