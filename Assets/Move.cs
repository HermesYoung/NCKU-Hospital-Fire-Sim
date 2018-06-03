using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using HTC.UnityPlugin.Vive;  
using HTC.UnityPlugin.Pointer3D;  
  
public class Move : MonoBehaviour {  
  
    /// <summary>  
    /// 玩家  
    /// </summary>  
    public Transform player;  
  
    /// <summary>  
    /// 方向   
    /// </summary>  
    public Transform dic;  
  
    /// <summary>  
    /// 速度  
    /// </summary>  
    public float speed;  
  
    public GameObject targetObj = null;  
  
    private ReticlePoser rp;  
    void Awake()  
    {  
        rp = GameObject.Find ("VivePointers/Right/Reticle").GetComponent<ReticlePoser>();  
    }  
  
    // Update is called once per frame  
    void FixedUpdate () {  
        targetObj = rp.raycaster.FirstRaycastResult().gameObject;  
  
        //按下圆盘键  
        if (ViveInput.GetPress(HandRole.RightHand,ControllerButton.PadTouch))  
        {  
            Vector2 cc = ViveInput.GetPadTouchAxis(HandRole.RightHand);  
            float angle = VectorAngle(new Vector2(1, 0), cc);  
  
            //下  
            if (angle > 45 && angle < 135)  
            {  
                player.Translate(-dic.forward * Time.deltaTime * speed);  
            }  
            //上    
            else if (angle < -45 && angle > -135)  
            {  
                //Debug.Log("上");  
                player.Translate(dic.forward * Time.deltaTime * speed);  
            }  
            //左    
            else if ((angle < 180 && angle > 135) || (angle < -135 && angle > -180))  
            {  
                //Debug.Log("左");  
                player.Translate(-dic.right * Time.deltaTime * speed);  
            }  
            //右    
            else if ((angle > 0 && angle < 45) || (angle > -45 && angle < 0))  
            {  
                //Debug.Log("右");  
                player.Translate(dic.right * Time.deltaTime * speed);  
            }  
        }  
        if (ViveInput.GetPress(HandRole.LeftHand,ControllerButton.Pad)) {  
            Vector2 cc = ViveInput.GetPadTouchAxis(HandRole.LeftHand);  
            float angle = VectorAngle(new Vector2(1, 0), cc);  
  
            //下  
            if (angle > 45 && angle < 135)  
            {  
                player.Translate(-dic.up * Time.deltaTime * speed);  
            }  
            //上    
            else if (angle < -45 && angle > -135)  
            {  
                //Debug.Log("上");  
                player.Translate(dic.up * Time.deltaTime * speed);  
            }  
        }  
    }  
  
  
//  void OnTriggerEnter(Collider collider){  
//      Debug.Log("cube");  
//  }  
//  void OnCollisionEnter(){  
//      Debug.Log("cube");  
//  }  
    /// <summary>  
    /// 根据在圆盘才按下的位置，返回一个角度值  
    /// </summary>  
    /// <param name="from"></param>  
    /// <param name="to"></param>  
    /// <returns></returns>  
    float VectorAngle(Vector2 from, Vector2 to)  
    {  
        float angle;  
        Vector3 cross = Vector3.Cross(from, to);  
        angle = Vector2.Angle(from, to);  
        return cross.z > 0 ? -angle : angle;  
    }  
}  