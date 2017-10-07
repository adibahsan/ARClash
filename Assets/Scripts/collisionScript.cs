using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collisionScript : MonoBehaviour {

	public static int myint;
	public Text text;

  // Use this for initialization
  void Start () {


  	myint =0;

  }

  // Update is called once per frame
  void Update () {

  }

  //for this to work both need colliders, one must have rigid body (spaceship) the other must have is trigger checked.
  void OnTriggerEnter (Collider col)
  {
  	myint += 10;
  	print(myint);
    GameObject explosion = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
    explosion.transform.position = transform.position;
    Destroy(col.gameObject);
    Destroy (explosion, 2);


    if (GameObject.FindGameObjectsWithTag("Player").Length == 0){

      GameObject enemy = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
      GameObject enemy1 = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
      GameObject enemy2 = Instantiate(Resources.Load("enemy2", typeof(GameObject))) as GameObject;
      GameObject enemy3 = Instantiate(Resources.Load("enemy3", typeof(GameObject))) as GameObject;
		GameObject enemy4 = Instantiate(Resources.Load("enemy4", typeof(GameObject))) as GameObject;
      GameObject enemy5 = Instantiate(Resources.Load("enemy5", typeof(GameObject))) as GameObject;
      GameObject enemy6 = Instantiate(Resources.Load("enemy6", typeof(GameObject))) as GameObject;
			GameObject enemy7 = Instantiate(Resources.Load("enemy7", typeof(GameObject))) as GameObject;
      GameObject enemy8 = Instantiate(Resources.Load("enemy8", typeof(GameObject))) as GameObject;
      GameObject enemy9 = Instantiate(Resources.Load("enemy9", typeof(GameObject))) as GameObject;

    }

    Destroy (gameObject);


  }

}