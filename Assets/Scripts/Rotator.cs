using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update roda a cada frame (várias vezes por segundo)
    void Update()
    {
        // Gira o objeto nos três eixos.
        // Time.deltaTime deixa a rotação suave e igual
        // em computadores rápidos ou lentos.
        transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
    }
}
