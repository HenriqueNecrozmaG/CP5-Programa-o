using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokemonManager : MonoBehaviour
{
    [Header("Pokémon Settings")]
    [SerializeField] private GameObject sceptile;
    [SerializeField] private GameObject mSceptile;

    [SerializeField] private GameObject blaziken;
    [SerializeField] private GameObject mBlaziken;

    [SerializeField] private GameObject swampert;
    [SerializeField] private GameObject mSwampert;

    [SerializeField] private GameObject groudon;
    [SerializeField] private GameObject mGroudon;

    [SerializeField] private GameObject kyogre;
    [SerializeField] private GameObject mKyogre;

    [SerializeField] private GameObject rayquaza;
    [SerializeField] private GameObject mRayquaza;

    [Header("UI Settings")]
    [SerializeField] private TextMeshProUGUI textPokemonInfo;
    [SerializeField] private Toggle toggleMega;


    private bool isSceptileActive;
    private bool isMSceptileActive;

    private bool isBlazikenActive;
    private bool isMBlazikenActive;

    private bool isSwampertActive;
    private bool isMSwampertActive;

    private bool isGroudonActive;
    private bool isMGroudonActive;

    private bool isKyogreActive;
    private bool isMKyogreActive;

    private bool isRayquazaActive;
    private bool isMRayquazaActive;

    public void Start()
    {
        isSceptileActive = true;
        isMSceptileActive = false;
        sceptile.transform.eulerAngles = new Vector3(0, 180, 0);
        mSceptile.transform.eulerAngles = new Vector3(0, 180, 0);

        isBlazikenActive = false;
        isMBlazikenActive = false;
        blaziken.transform.eulerAngles = new Vector3(0, 180, 0);
        mBlaziken.transform.eulerAngles = new Vector3(0, 180, 0);

        isSwampertActive = false;
        isMSwampertActive = false;
        swampert.transform.eulerAngles = new Vector3(0, 180, 0);
        mSwampert.transform.eulerAngles = new Vector3(0, 180, 0);

        isGroudonActive = false;
        isMGroudonActive = false;
        groudon.transform.eulerAngles = new Vector3(0, 180, 0);
        mGroudon.transform.eulerAngles = new Vector3(0, 180, 0);

        isKyogreActive = false;
        isMKyogreActive = false;
        kyogre.transform.eulerAngles = new Vector3(0, 180, 0);
        mKyogre.transform.eulerAngles = new Vector3(0, 180, 0);

        isRayquazaActive = false;
        isMRayquazaActive = false;
        rayquaza.transform.eulerAngles = new Vector3(0, 180, 0);
        mRayquaza.transform.eulerAngles = new Vector3(0, 180, 0);

        toggleMega.isOn = false;
    }

    void Update()
    {
        activatePokémon();
        ToggleMega();
    }

    private void activatePokémon()
    {
        if (isSceptileActive)
        {
            sceptile.SetActive(true);
            textPokemonInfo.text = "Sceptile - #254";
        }
        else
        {
            sceptile.SetActive(false);
        }

        if (isMSceptileActive)
        {
            mSceptile.SetActive(true);
            textPokemonInfo.text = "Mega Sceptile - #254";
        }
        else
        {
            mSceptile.SetActive(false);
        }

        if (isBlazikenActive)
        {
            blaziken.SetActive(true);
            textPokemonInfo.text = "Blaziken - #257";
        }
        else
        {
            blaziken.SetActive(false);
        }

        if (isMBlazikenActive)
        {
            mBlaziken.SetActive(true);
            textPokemonInfo.text = "Mega Blaziken - #257";
        }
        else
        {
            mBlaziken.SetActive(false);
        }

        if (isSwampertActive)
        {
            swampert.SetActive(true);
            textPokemonInfo.text = "Swampert - #260";
        }
        else
        {
            swampert.SetActive(false);
        }

        if (isMSwampertActive)
        {
            mSwampert.SetActive(true);
            textPokemonInfo.text = "Mega Swampert - #260";
        }
        else
        {
            mSwampert.SetActive(false);
        }

        if (isGroudonActive)
        {
            groudon.SetActive(true);
            textPokemonInfo.text = "Groudon - #383";
        }
        else
        {
            groudon.SetActive(false);
        }

        if (isMGroudonActive)
        {
            mGroudon.SetActive(true);
            textPokemonInfo.text = "Primal Groudon - #383";
        }
        else
        {
            mGroudon.SetActive(false);
        }

        if (isKyogreActive)
        {
            kyogre.SetActive(true);
            textPokemonInfo.text = "Kyogre - #382";
        }
        else
        {
            kyogre.SetActive(false);
        }

        if (isMKyogreActive)
        {
            mKyogre.SetActive(true);
            textPokemonInfo.text = "Primal Kyogre - #382";
        }
        else
        {
            mKyogre.SetActive(false);
        }

        if (isRayquazaActive)
        {
            rayquaza.SetActive(true);
            textPokemonInfo.text = "Rayquaza - #384";
        }
        else
        {
            rayquaza.SetActive(false);
        }

        if (isMRayquazaActive)
        {
            mRayquaza.SetActive(true);
            textPokemonInfo.text = "Mega Rayquaza - #384";
        }
        else
        {
            mRayquaza.SetActive(false);
        }
    }

    private void ToggleMega()
    {
        if (toggleMega.isOn)
        {
            if (isSceptileActive)
            {
                isSceptileActive = false;
                isMSceptileActive = true;
            }
            else if (isBlazikenActive)
            {
                isBlazikenActive = false;
                isMBlazikenActive = true;
            }
            else if (isSwampertActive)
            {
                isSwampertActive = false;
                isMSwampertActive = true;
            }
            else if (isGroudonActive)
            {
                isGroudonActive = false;
                isMGroudonActive = true;
            }
            else if (isKyogreActive)
            {
                isKyogreActive = false;
                isMKyogreActive = true;
            }
            else if (isRayquazaActive)
            {
                isRayquazaActive = false;
                isMRayquazaActive = true;
            }
        }
        else
        {
            if (isMSceptileActive)
            {
                isMSceptileActive = false;
                isSceptileActive = true;
            }
            else if (isMBlazikenActive)
            {
                isMBlazikenActive = false;
                isBlazikenActive = true;
            }
            else if (isMSwampertActive)
            {
                isMSwampertActive = false;
                isSwampertActive = true;
            }
            else if (isMGroudonActive)
            {
                isMGroudonActive = false;
                isGroudonActive = true;
            }
            else if (isMKyogreActive)
            {
                isMKyogreActive = false;
                isKyogreActive = true;
            }
            else if (isMRayquazaActive)
            {
                isMRayquazaActive = false;
                isRayquazaActive = true;
            }
        }
    }

    public void ButtonNextPokémon()
    {
        if (isSceptileActive)
        {
            isSceptileActive = false;
            isBlazikenActive = true;
        }
        else if (isBlazikenActive)
        {
            isBlazikenActive = false;
            isSwampertActive = true;
        }
        else if (isSwampertActive)
        {
            isSwampertActive = false;
            isKyogreActive = true;
        }
        else if (isKyogreActive)
        {
            isKyogreActive = false;
            isGroudonActive = true;
        }
        else if (isGroudonActive)
        {
            isGroudonActive = false;
            isRayquazaActive = true;
        }
        else if (isRayquazaActive)
        {
            return;
        }

        if (isMSceptileActive)
        {
            isMSceptileActive = false;
            isMBlazikenActive = true;
        }
        else if (isMBlazikenActive)
        {
            isMBlazikenActive = false;
            isMSwampertActive = true;
        }
        else if (isMSwampertActive)
        {
            isMSwampertActive = false;
            isMKyogreActive = true;
        }
        else if (isMKyogreActive)
        {
            isMKyogreActive = false;
            isMGroudonActive = true;
        }
        else if (isMGroudonActive)
        {
            isMGroudonActive = false;
            isMRayquazaActive = true;
        }
        else if (isMRayquazaActive)
        {
            return;
        }
    }

    public void ButtonPreviousPokémon()
    {
        if (isSceptileActive)
        {
            return;
        }
        else if (isBlazikenActive)
        {
            isBlazikenActive = false;
            isSceptileActive = true;
        }
        else if (isSwampertActive)
        {
            isSwampertActive = false;
            isBlazikenActive = true;
        }
        else if (isKyogreActive)
        {
            isKyogreActive = false;
            isSwampertActive = true;
        }
        else if (isGroudonActive)
        {
            isGroudonActive = false;
            isKyogreActive = true;
        }
        else if (isRayquazaActive)
        {
            isRayquazaActive = false;
            isGroudonActive = true;
        }

        if (isMSceptileActive)
        {
            return;
        }
        else if (isMBlazikenActive)
        {
            isMBlazikenActive = false;
            isMSceptileActive = true;
        }
        else if (isMSwampertActive)
        {
            isMSwampertActive = false;
            isMBlazikenActive = true;
        }
        else if (isMKyogreActive)
        {
            isMKyogreActive = false;
            isMSwampertActive = true;
        }
        else if (isMGroudonActive)
        {
            isMGroudonActive = false;
            isMKyogreActive = true;
        }
        else if (isMRayquazaActive)
        {
            isMRayquazaActive = false;
            isMGroudonActive = true;
        }
    }
}