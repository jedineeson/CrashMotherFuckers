using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemWall : MonoBehaviour
{
    public bool isLeft = false;
    public bool isRight = false;
    public bool isTop = false;
    public bool isBottom = false;

    private Vector3 Voffset = new Vector3(1, 1, -1);
    private Vector3 Hoffset = new Vector3(-1, 1, 1);

    private void OnCollisionEnter(Collision aOther)
    {
        Ball ball = aOther.gameObject.GetComponent<Ball>();
        if (isLeft)
        {         
            ball.SetDir(new Vector3 (-ball.GetDir().x, ball.GetDir().y, ball.GetDir().z));
        }
        else if(isRight)
        {
            ball.SetDir(new Vector3(-ball.GetDir().x, ball.GetDir().y, ball.GetDir().z));
        }
        else if(isTop)
        {
            ball.SetDir(new Vector3(ball.GetDir().x, ball.GetDir().y, -ball.GetDir().z));
        }
        else if(isBottom)
        {
            ball.SetDir(new Vector3(ball.GetDir().x, ball.GetDir().y, -ball.GetDir().z));
        }
    }
}
