using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IP_TopDownCamera : MonoBehaviour
{
    //region variables

    [SerializeField]
    private Transform m_Target;

    [SerializeField]
    private float m_Height = 10f;

    [SerializeField]
    private float m_Distance = 20f;

    [SerializeField]
    private float m_Angle = 45f;

    [SerializeField]
    private float m_SmoothSpeed = 0.5f;

    private Vector3 refVelocity;
    //endregion


    //region Main Methods
    // Start is called before the first frame update
    void Start()
    {
        HandleCamera();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCamera();
    }
    //endregion

    //region Helper Methods
    protected virtual void HandleCamera()
    {
        if (!m_Target)
        {
            return;
        }
        //Build World position vector
        Vector3 worldPosition = (Vector3.forward * -m_Distance) + (Vector3.up * m_Height);
       

        //Build our Rotated vector
        Vector3 rotatedVector = Quaternion.AngleAxis(m_Angle, Vector3.up) * worldPosition;

        //move our position
        Vector3 flatTargetPosition = m_Target.position;
        flatTargetPosition.y = 0f;
        Vector3 finalPosition = flatTargetPosition + rotatedVector;

        transform.position = Vector3.SmoothDamp(transform.position, finalPosition, ref refVelocity, m_SmoothSpeed);
        transform.LookAt(flatTargetPosition);

    
        
    }
    //endregion
}
