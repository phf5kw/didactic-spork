using UnityEngine;
public class Movementcontroller : MonoBehaviour
{
    void Update()
    {
        if(direction_right){
            //go right
            transform.Translate(6f * Time.deltaTime, 0f, 0f);
        }
        else{
            //go left
            transform.Translate(-6f * Time.deltaTime, 0f, 0f);
        }
    }
}