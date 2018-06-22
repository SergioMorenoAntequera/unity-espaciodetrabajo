using UnityEngine;

public class DestruirCubos : MonoBehaviour {

    GameObject objeto;

    public void Destruir(string aDestruir)
    {

        objeto = GameObject.Find(aDestruir);
        Destroy(objeto);

    }
}
