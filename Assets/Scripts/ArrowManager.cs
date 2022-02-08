using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowManager : MonoBehaviour
{
    public static ArrowManager Instance;

    private List<GameObject> _arrowList = new List<GameObject>();

    [SerializeField] private GameObject _parentObj;
    [SerializeField] private GameObject _arrowObj;

    private Vector3 _arrowScale = new Vector3(0.0333333351f, 0.600000024f, 0.0333333351f);


    private void Awake()
    {
        Instance = this;
    }


    void Start()
    {
        for (int i = 0; i < _parentObj.transform.childCount; i++)
        {
            _arrowList.Add(_parentObj.transform.GetChild(i).gameObject);
        }
        
    }

    void Update()
    {

    }

    private void FermatSpiralPlacement() // Child objeleri fermat denklemine göre spiral bir alanda sýralar
    {
        float goldenAngle = 137.5f * 1f;

        for (int i = 0; i < transform.childCount; i++)
        {
            float x = 0.3f * Mathf.Sqrt(i + 1) * Mathf.Cos(Mathf.Deg2Rad * goldenAngle * (i + 1)); //0.3f aralarýndaki uzaklýk için
            float y = 0.3f * Mathf.Sqrt(i + 1) * Mathf.Sin(Mathf.Deg2Rad * goldenAngle * (i + 1));
            
            Vector3 arrowLocalPosition = new Vector3(x, y, 0);
            
            transform.GetChild(i).localPosition = Vector3.Lerp(transform.GetChild(i).localPosition, arrowLocalPosition, 0.1f); // parent merkezine yakýn olmasý için 0.1f
        }
    }


    public void AssignArrows() //Parent objesinde bulunan arrowlarýn pos. sýfýrlar,istenen sayýda yeni arrow oluþturur ve arrowlarýn pozisyonunu ayarlar.
    {
        ResetArrowPosition();

        FermatSpiralPlacement();

    }


    public void ResetArrowPosition() // arrowlist içindeki arrow objelerinin pozisyonunu parent objesinin merkezine getirir
    {
        foreach (GameObject arrow in _arrowList)
        {
            arrow.transform.localPosition = Vector3.zero;
        }
    }

    public void IncreaseArrow(int spawnAmount)
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            GameObject go = Instantiate(_arrowObj);
            Transform trans = go.transform;

            //trans.localScale = Vector3.zero;
            //trans.DOScale(_arrowScale * 2, .5f).OnComplete(() => { trans.DOScale(_arrowScale, .3f); }); 


            trans.transform.SetParent(_parentObj.transform, false);
            trans.transform.localPosition = Vector3.zero; //parent merkezine atama
            trans.name = "Arrow : " + i;
            _arrowList.Add(go);
        }

        AssignArrows();
        Debug.Log(_arrowList.Count);
    }


    public void DecreaseArrow(int decreaseAmount)
    {
        for (int i = 0 ; i < decreaseAmount; i++)
        {
            _arrowList.RemoveAt(_arrowList.Count-1);
            Destroy(_parentObj.transform.GetChild(_arrowList.Count).gameObject);
        }
        
        AssignArrows();

        Debug.Log(_arrowList.Count);
    }

    public void ShootWithArrow(GameObject target)
    {
        Vector3 spawnLoc = new Vector3(0,0,-1); // localPosition vector for arrow instantiation which is 1 unit behind from enemy

        GameObject go = Instantiate(_arrowObj);
        go.transform.SetParent(target.transform,false);
        go.transform.localPosition = spawnLoc;

    }

    public int GetArrowNumber()
    {
        return _arrowList.Count;
    }

}