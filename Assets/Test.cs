﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力
        private int mp = 53; // 魔法

        // 攻撃用の関数
        public void Attack() {
                Debug.Log( this.power + "のダメージを与えた" );
        }

        // 防御用の関数
        public  void Defence(int damage) {
                Debug.Log( damage+"のダメージを受けた" );
                // 残りhpを減らす
                this.hp -= damage;
        }

        // 魔法攻撃用の関数
        public void Magic(int cm){
                if(this.mp >= cm){
                        //mpを減らす
                        this.mp -= cm;
                        Debug.Log("魔法攻撃をした。残りMPは"+this.mp+"。");
                }else{
                        Debug.Log("MPが足りないため魔法が使えない。");
                }
        }

}
public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
                int[] array = {10,30,70,50,2};
                for(int i = 0; i < array.Length; i++){
                        Debug.Log(array[i]);
                }
                for(int j = array.Length-1; j >= 0; j--){
                        Debug.Log(array[j]);
                }
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss();
                Boss midboss = new Boss();

		//攻撃用の関数を呼び出す
		lastboss.Attack();
                midboss.Attack();
		//防御用の関数を呼び出す
		lastboss.Defence(3);
                midboss.Defence(10);
                //魔法攻撃用の関数を呼び出す
                for(int i = 0; i < 11; i++){
                        lastboss.Magic(5);
                }
	}

	// Update is called once per frame
	void Update () {

	}
}
