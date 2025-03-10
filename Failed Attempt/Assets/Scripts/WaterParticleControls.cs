using UnityEngine;

public class WaterParticleControls : MonoBehaviour
{
    public GameObject waterParticles;
    public ParticleSystem waterParticleSystem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var main = waterParticleSystem.main;

        if (Input.GetKey(KeyCode.Space))
        {
            main.loop = true;
            waterParticleSystem.Play();
        }
        else
        {
            main.loop = false;
        }
    }
}
