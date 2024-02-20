using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChissanuScript : MonoBehaviour
{
    public GameObject playerCamera;
    [SerializeField] private Animator animator;
    

    private bool isClose = false;
    private Quaternion originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        originalRotation = this.gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((gameObject.transform.position - playerCamera.transform.position).sqrMagnitude < 40f)
        {
            this.gameObject.transform.LookAt(playerCamera.transform.position);
            isClose = true;
            
        } else
        {
            this.gameObject.transform.rotation = originalRotation;
            isClose = false;
        }
        animator.SetBool("isClose", isClose);
    }

}
