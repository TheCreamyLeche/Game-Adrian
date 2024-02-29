using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    private string _selectTag;
    private bool _ishighlighted = false;

    private Transform _slection;

    public TMP_Text nameDisplay;

    public float distanceFromItem = 3f;

    private void Update()
    {
        if (_selection != null)
        {
            nameDisplay.text = "";
            _ishighlighted = false;
            Renderer selectionRenderer = _selection.GetComponent<selectionRenderer>();
            selectionRenderer.material.DisableKeyword("_EMISSION");

            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Debug.DrawRay(Camera.mainb.transform.position, Camera.main.transform.forward * distanceFromItem, Color.red);
        
        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transformn.forward, out hit, distanceFromItem))
        {
            Debug.log("test");

            var selection = hit.transform;

            if(selection.CompareTag("Selectable") || selection.CompareTag("Door"))
            {
                if (selection != _ishighlighted)
                {
                    _ishighlighted = true;
                    selection.getComponent<Renderer>().material.EnableKeyword("_EMISSION");
                    nameDisplay.text = selection.gameObject.name;
                }

                _slection = selection;
            }
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            DoorInteraction():
        }
    }

    void Doorinteraction()
    {
        Debug.log("test");

        RayCastHit hitInfo;

        Vector2 mousePosition = mousePosition.current.position.ReadValue();

        Ray rayOrigin = Camera.main.ScreenPointToRay(mousePosition);

        if (!haskey)
        {
            doorText.SetActive(true);
            invoke("DisabledText", 2f);

        }
    }

    void DisabledText()
    {
        doorText.SetActive(false);
    }

    private void onTriggerEnter()
}
