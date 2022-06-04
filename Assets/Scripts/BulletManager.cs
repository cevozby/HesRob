using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    Vector3 startPos;
    Vector3 targetPos;
    Vector3 movePos;
    public GameObject bullet;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        startPos = bullet.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Target();
        BulletMovement();
    }

    void Target()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bullet.SetActive(true);
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void BulletMovement()
    {
        movePos = (targetPos - startPos);
        bullet.transform.Translate(new Vector3(movePos.x, movePos.y, 0f) * speed * Time.deltaTime);
    }

}
