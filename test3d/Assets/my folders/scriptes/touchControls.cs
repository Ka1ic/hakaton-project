using UnityEngine;
using UnityEngine.EventSystems;

public class touchControls : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [Range(0, 2)] [SerializeField]  private float offset;

    [SerializeField] private AudioSource sicko;

    private bool priviousCondition = false;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log(priviousCondition);

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("target") && !EventSystem.current.IsPointerOverGameObject())
                {
                    if (!priviousCondition)
                    {
                        priviousCondition = true;

                        sicko.Play();
                    }

                    Vector3 mousePosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.transform.position.y - offset));

                    hit.transform.position = mousePosition;
                }
                else
                {
                    priviousCondition = false;

                    sicko.Stop();
                }
            } 
            else
            {
                priviousCondition = false;

                sicko.Stop();
            }
        }
        else
        {
            priviousCondition = false;

            sicko.Stop();
        }
    }
}
