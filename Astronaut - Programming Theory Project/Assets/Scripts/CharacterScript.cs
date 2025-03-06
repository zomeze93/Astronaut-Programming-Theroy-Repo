using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
   
    [Header ("Life")]
    private float _life;
    private float _maxLife;
    //encapsulación
    public float LifeValue()
    {
        get { return _life; }
        ser { _life = value < 0 ? 0 : value; }
    }

    [Header ("Movement")]
    private float _moveSpeed;
    private float _mh;
    private float _mv;
    private RigidBody _rigid;
    private Colider _col;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
        _col = GetComponent<Colider>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        _mh = Input.GetAxis("horizontal");
        _mv = Input.GetAxis("vertical");
        
        MovePlayer(_mh,_mv);
    }

    public void MovePlayer(float mh, float mv)
    {
        _rigid.velocity = new Vector3(mh,0,mv) * _moveSpeed;
    }

    // abstraccion
    //private void GetHit()
}
