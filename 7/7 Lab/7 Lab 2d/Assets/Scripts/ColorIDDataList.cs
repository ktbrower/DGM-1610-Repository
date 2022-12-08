
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;
    
    public ColorID currentColor;

    private int num;

    public void SetCurrentColorRandomly()
    {
        num = colorIDList.Count - 1;
        currentColor = colorIDList[num];
        
    }
}
