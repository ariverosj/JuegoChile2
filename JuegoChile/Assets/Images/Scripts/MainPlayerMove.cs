using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UIElements;

public class MainPlayerMove : MonoBehaviour
{
    float moveVectorXValue; 
    float deltaMove=0;
    float aceleration=1.2f;

    [SerializeField]float a;
    [SerializeField]float b; 
    [SerializeField]float c; 

    
    public float setDeltaMove()
    {
         float deltaMoveVar = this.deltaMove + 2* aceleration;
         return deltaMoveVar;
    }

    private float despejarXEnfuncionCuadratica(float a , float b , float c )
    {
        // xcuadrado + 2 x + 5 =0
        // a x2 + bx + c= 
        //x= (-b+- raiz (b2 -4ac)) /2a 
        return  (-b + Mathf.Sqrt(b*b-(4*a*c )))/(2*a);
    } 


    
    // Start is called before the first frame update
    void Start()
    {
        print("El valor de x = " + despejarXEnfuncionCuadratica(this.a,this.b,this.c));
        this.deltaMove= setDeltaMove();
        this.deltaMove= setDeltaMove();
    }


    void  Awake()
    {
        
    }

    void imprimirMoveVectorXValueEnPantalla()
    {
        print("El valor actual de moveVectorXValue es igual a " + moveVectorXValue);
    }

    void moveInDirectionX()
    {
        //suma de valores de 1 a 200
        for(int i=1;i<201;i++)
        {
            moveVectorXValue= moveVectorXValue+0.00001f+i;
        } 
        
        moveVectorXValue= moveVectorXValue+0.00001f;
        transform.Translate(moveVectorXValue,0,0);

    }

    // Update is called once per frame
    void Update()
    {

         imprimirMoveVectorXValueEnPantalla();
        moveInDirectionX(); 
       
        
    }
}
