using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class positionControls : MonoBehaviour
{
    [SerializeField] private GameObject cameraView;

    [SerializeField] private float step = 0.01f;

    [SerializeField] private AudioSource sickoMode;

    private float x = 0;

    private float y = 0;

    private float z = 0;

    public void Update()
    {
        if (x == 0 && y == 0 && z == 0)
        {
            sickoMode.Stop();
        }
        else
        {
            if(!sickoMode.isPlaying)
            {
                sickoMode.Play();
            }
        }

        transform.position = new Vector3(transform.position.x + x, transform.position.y + y, transform.position.z + z);
    }

    public void moveUp()
    {
        y += step;
    }
    
    public void moveDown()
    {
        y -= step;
    }

    public void moveLeft()
    {
        float rotationZ = cameraView.transform.rotation.eulerAngles.y;

        float rotationX = cameraView.transform.rotation.eulerAngles.y + 90;

        if(rotationX > 360)
        {
            rotationX -= 360;
        }

        if (rotationZ > 0 && rotationZ > 90)
        {
            rotationZ = rotationZ - (rotationZ - 90) * 2;
        }

        if (rotationZ < 0 && rotationZ < -90)
        {
            rotationZ = rotationZ - (rotationZ + 90) * 2;
        }

        if (rotationX > 0 && rotationX > 90)
        {
            rotationX = rotationX - (rotationX - 90) * 2;
        }

        if (rotationX < 0 && rotationX < -90)
        {
            rotationX = rotationX - (rotationX + 90) * 2;
        }

        z += (rotationZ) / (90 / step);

        x -= (rotationX) / (90 / step);
    }

    public void moveRight()
    {
        float rotationZ = cameraView.transform.rotation.eulerAngles.y;

        float rotationX = cameraView.transform.rotation.eulerAngles.y + 90;

        if (rotationX > 360)
        {
            rotationX -= 360;
        }

        if (rotationZ > 0 && rotationZ > 90)
        {
            rotationZ = rotationZ - (rotationZ - 90) * 2;
        }

        if (rotationZ < 0 && rotationZ < -90)
        {
            rotationZ = rotationZ - (rotationZ + 90) * 2;
        }

        if (rotationX > 0 && rotationX > 90)
        {
            rotationX = rotationX - (rotationX - 90) * 2;
        }

        if (rotationX < 0 && rotationX < -90)
        {
            rotationX = rotationX - (rotationX + 90) * 2;
        }

        z -= (rotationZ) / (90 / step);

        x += (rotationX) / (90 / step);
    }

    public void moveForward()
    {
        float rotationZ = cameraView.transform.rotation.eulerAngles.y;

        float rotationX = cameraView.transform.rotation.eulerAngles.y + 90;

        if (rotationX > 360)
        {
            rotationX -= 360;
        }

        if (rotationZ > 0 && rotationZ > 90)
        {
            rotationZ = rotationZ - (rotationZ - 90) * 2;
        }

        if (rotationZ < 0 && rotationZ < -90)
        {
            rotationZ = rotationZ - (rotationZ + 90) * 2;
        }

        if (rotationX > 0 && rotationX > 90)
        {
            rotationX = rotationX - (rotationX - 90) * 2;
        }

        if (rotationX < 0 && rotationX < -90)
        {
            rotationX = rotationX - (rotationX + 90) * 2;
        }

        z += (rotationX) / (90 / step);

        x += (rotationZ) / (90 / step);
    }

    public void moveBack()
    {
        float rotationZ = cameraView.transform.rotation.eulerAngles.y;

        float rotationX = cameraView.transform.rotation.eulerAngles.y + 90;

        if (rotationX > 360)
        {
            rotationX -= 360;
        }

        if (rotationZ > 0 && rotationZ > 90)
        {
            rotationZ = rotationZ - (rotationZ - 90) * 2;
        }

        if (rotationZ < 0 && rotationZ < -90)
        {
            rotationZ = rotationZ - (rotationZ + 90) * 2;
        }

        if (rotationX > 0 && rotationX > 90)
        {
            rotationX = rotationX - (rotationX - 90) * 2;
        }

        if (rotationX < 0 && rotationX < -90)
        {
            rotationX = rotationX - (rotationX + 90) * 2;
        }

        z -= (rotationX) / (90 / step);

        x -= (rotationZ) / (90 / step);
    }

    public void stop()
    {
        x = 0;

        y = 0;

        z = 0;
    }
}
