using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    public Cell[,] cells;
    public GameObject cellPrefab;
    public float cellSpacing = 16f;

    public GameObject indicatorPrefab;
    public Dictionary<int, SumIndicator> rowIndicators = new Dictionary<int, SumIndicator>();
    public Dictionary<int, SumIndicator> colIndicators = new Dictionary<int, SumIndicator>();
    public int rowCount = 5;
    public int colCount = 5;

    public void InitGrid()
    {
        for (int i = 0; i < rowCount; i++)
        {
            GameObject currentRow = InitRow();
            for (int j = 0; j < colCount; j++)
            {
                cells[i, j] = InitCell((i ,j), currentRow);

                // Add a sum indicator if the cell is at the end of a row
                if (j == colCount - 1)
                {
                    rowIndicators[i] = InitIndicator(currentRow);
                }
            }
            // Add a sum indicator if the cell is at the end of a col
            if (i == rowCount - 1)
            {
                colIndicators[i] = InitIndicator(currentRow);
            }
        }
    }

    public GameObject InitRow()
    {
        GameObject row = new GameObject("Row");
        row.transform.parent = transform;
        HorizontalLayoutGroup HLG = row.AddComponent<HorizontalLayoutGroup>();
        HLG.childForceExpandWidth = true;
        HLG.childForceExpandWidth = true;
        HLG.spacing = cellSpacing;
        return row;
    }

    public Cell InitCell((int x, int y) coords, GameObject row)
    {
        GameObject cellObject = Instantiate(cellPrefab, row.transform);
        Cell cell = cellObject.GetComponent<Cell>();
        cell.Init(coords);
        return cell;
    }

    public SumIndicator InitIndicator(GameObject row)
    {
        GameObject indicatorObject = Instantiate(indicatorPrefab, row.transform);
        SumIndicator indicator = indicatorObject.GetComponent<SumIndicator>();
        return indicator;
    }
}
