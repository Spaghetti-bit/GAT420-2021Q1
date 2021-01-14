using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentCreator : MonoBehaviour
{
    public BasicAgent[] agents;
    public LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hitInfo, 100, layerMask))
            {
                BasicAgent agent = Instantiate(agents[0]);
                agent.transform.position = hitInfo.point;
                agent.transform.rotation = Quaternion.identity;
            }
        }
        
    }
}
