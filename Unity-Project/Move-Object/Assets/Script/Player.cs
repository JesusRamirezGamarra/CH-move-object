using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 changeScale = new Vector3(-0.001f,-0.001f,-0.001f);

    public float moveSpeed = 0.10f;
    public Vector3 moveDirectionDestiny = new Vector3(0f,0f,0f);
    private Vector3 moveSpeedxAxis =new Vector3(0f,0f,0f);
    
    //public Vector3 moveDirection = new Vector3(0f,0f,0f);

    // Start is called before the first frame update
    void Start()
    {
        // Al darle play, cambie su escala a un nuevo valor (modificable por inspector ) . 
        // NO se detalla que cambie con cada frame o de forma continua
        transform.localScale += changeScale;
        // int x = 1;
        // int y = 1;
        // int z = 1;
        // if (moveDirection.x == 0f )
        //     x =0;
        // if (moveDirection.y == 0f)
        //     y=0;
        // if (moveDirection.z == 0f)
        //     z=0;            

        // moveSpeedxAxis =new Vector3( moveSpeed*x,moveSpeed*y,moveSpeed*z);
        moveSpeedxAxis =new Vector3( moveSpeed,moveSpeed,moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {

        //con cada frame se mueva en una dirección y con una velocidad determinadas (también modificables desde el inspector).
        //por condicion de problema se puede asumir una velocidad constante en todas las direcciones o velocidades variables x eje con lo que la variable moveSpeed deberi ser declara como Vector3
        // moveDirection += moveSpeedxAxis;
        // Debug.Log(moveDirection);
        //transform.Translate(moveDirection);
        transform.Translate(moveSpeedxAxis);
        
    }
}
