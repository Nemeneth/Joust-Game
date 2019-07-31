using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private bool isPressed;

    private float releaseDelay;

    private Copy Cp;

    private Rigidbody2D rb;
    private SpringJoint2D sj;

    private IEnumerator coroutine;

    GameObject Kopia;

    public Text WinText;


    public void YouWin()
    {
        WinText.gameObject.SetActive(true);
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sj = GetComponent<SpringJoint2D>();

        releaseDelay = 1 / (sj.frequency * 4);
    }

    void Update()
    {
        if (isPressed)
        {
            DragBall();
        }
    }

    private void DragBall()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rb.position = mousePosition;

    }

    private void OnMouseDown()
    {

        isPressed = true;
        rb.isKinematic = true;

    }


    private void OnMouseUp()
    {
        

        isPressed = false;
        rb.isKinematic = false;

        float move = Input.GetAxis("Horizontal");
        StartCoroutine(Release());

    }


    private IEnumerator Release()
    {
        while (true)
        {

            if(Input.GetAxis("Horizontal") > 0)
                Kopia.GetComponent<Copy>();

           
                

            yield return new WaitForSeconds(releaseDelay);
            sj.enabled = false;
            

        }

       

    }
}