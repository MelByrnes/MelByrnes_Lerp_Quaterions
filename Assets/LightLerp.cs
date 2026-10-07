using UnityEngine;

public class LightLerp : MonoBehaviour
{

    private Vector3 newPosition;
    public float smooth = 2;
    private float newIntensity;
    private Color newColor;

    public Light light;

    private void Awake()
    {
        newPosition = transform.position;
        newIntensity = light.intensity;
        newColor = light.color;
    }
    // Update is called once per frame
    void Update()
    {
        PositionChanging();
        IntensityChanging();
        ColorChanging();
    }


    void ColorChanging()
    {
        Color A = Color.blue;
        Color B = Color.green;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            newColor = A;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            newColor = B;
        }

        light.color = Color.Lerp(light.color, newColor, Time.deltaTime * smooth);
    }

    void IntensityChanging()
    {
        float A = 0.5f;
        float B = 50f;

        if (Input.GetKeyDown(KeyCode.A))
        {
            newIntensity = A;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
           newIntensity = B;
        }

        light.intensity = Mathf.Lerp(light.intensity, newIntensity, Time.deltaTime* smooth);
    }

    void PositionChanging() {
        Vector3 positionA = new Vector3(-5, 3, 0);
        Vector3 positionB = new Vector3(5, 3, 0);

        if (Input.GetKeyDown(KeyCode.Q)) {
            newPosition = positionA;
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            newPosition = positionB;
        }

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * smooth);
    }


}
