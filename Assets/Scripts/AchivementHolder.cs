using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivementHolder : MonoBehaviour
{
    [SerializeField] private int ID;
    private AchivementRevarder _achivementRevarder;
    private AchivementRevarder.Achivement _thisAchivement;
    public Text _revard;
    public Image _achivementImage;
    public Text _description;
    public Text _name;
    public GameObject _button;
    private Color _doneAchivementColour = new Color(88 / 255.0f, 255 / 255.0f, 93 / 255.0f);

    void Start()
    {
        _achivementRevarder = GameObject.Find("GameManager").GetComponent<AchivementRevarder>();
        _thisAchivement = _achivementRevarder.achivements[ID];
        _name.text = _thisAchivement.Name.ToString();
        _revard.text = _thisAchivement.revard.ToString();
        _achivementImage = _thisAchivement.icon;
        _description.text = _thisAchivement.Description; 
        
    }

    void Update()
    {
        if (_achivementRevarder.achivements[ID].isRevardTaken)
            GetComponent<Image>().color = _doneAchivementColour;
    }
    
    public void CallForRevard()
    {
        _achivementRevarder.GetRevard(ID);
    }
}
