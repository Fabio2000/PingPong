using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class GameManager : MonoBehaviour {
 
        public int pontuacao1;
        public int pontuacao2;

        public Text Pontuacao;
        public Text Pontuacao2;
 
        // Use this for initialization
        void Start () {
                pontuacao1 = 0;
                pontuacao2 = 0;
        }
       
        // Update is called once per frame
        void Update () {

                Pontuacao.text = pontuacao1.ToString();
                Pontuacao2.text = pontuacao2.ToString();
 
        }
}