"use strict";
{
    let Core = Carina.Core;
    let LightGrid = Carina.LightGrid;

    Carina.LightGrid.LightGridCell = class extends Core.BaseControl
    {
        constructor(cellData,column)
        {
            super();
            this.Element = document.createElement("div");
            this.cellData = null;
            this.Element.setAttribute("id", cellData.Id);
            
            this.Style("position", "absolute");
            this.Style("display", "inline-block");
            this.column = column;
           
        
        }

        Render(cellData,columnData)
        {
            //if (this.CompareCellData(this.cellData, cellData))
            //    return;

            this.cellData = cellData;

            if (cellData.FormatInfo)
            {
                cellData.FormatInfo.Top = cellData.Top;
                cellData.FormatInfo.Left = cellData.Left;
            }
            
            this.Attribute("id", cellData.ColumnIndex.toString() + cellData.RowIndex.toString());

            this.Style("top", cellData.Top+"px" );
            this.Style("left", cellData.Left + "px");
            this.Height = columnData.Height;
            this.Width = columnData.Width;
            this.Style("color", cellData.FormatInfo ? cellData.FormatInfo.Foreground : columnData.Foreground);
            this.Style("backgroundColor", cellData.FormatInfo ? cellData.FormatInfo.Background : columnData.Background);
            this.Style("font-family", cellData.FormatInfo ? cellData.FormatInfo.FontFamily : columnData.FontFamily);
            this.Style("font-style", cellData.FormatInfo ? cellData.FormatInfo.FontStyle : columnData.FontStyle);
            this.Style("font-weight", cellData.FormatInfo ? cellData.FormatInfo.FontWeight : columnData.FontWeight);
            this.Style("visibility", cellData.FormatInfo ? cellData.FormatInfo.Visible : columnData.Visible);
            this.Style("font-size", cellData.FormatInfo ? cellData.FormatInfo.FontSize : columnData.FontSize);
            this.Style("border", cellData.FormatInfo ? cellData.FormatInfo.CellBorder + "px solid" : "0.5px solid" );
            this.Style("overflow", "hidden");
            this.Element.innerText = cellData.Data;
        }
        CompareInfo(prevFormatInfo,currentFormatInfo)
        {
            if (prevFormatInfo == undefined && currentFormatInfo)
            {
                return false;
            }
            else if (prevFormatInfo  && currentFormatInfo==undefined)
            {
                return false;
            }
            else if (prevFormatInfo == currentFormatInfo)
            {
                return true;
            }
            else if (prevFormatInfo == undefined || currentFormatInfo == undefined)
            {
                return false;
            }
            else
            {
                (prevFormatInfo.Editable == currentFormatInfo.Editable &&
                    prevFormatInfo.FontStyle == currentFormatInfo.FontStyle &&
                    prevFormatInfo.FontWeight == currentFormatInfo.FontWeight &&
                    prevFormatInfo.Foreground == currentFormatInfo.Foreground &&
                    prevFormatInfo.RowBorder == currentFormatInfo.RowBorder &&
                    prevFormatInfo.Scaling == currentFormatInfo.Scaling &&
                    prevFormatInfo.Strikethrough == currentFormatInfo.Strikethrough &&
                    prevFormatInfo.Underline == currentFormatInfo.Underline &&
                    prevFormatInfo.Visible == currentFormatInfo.Visible)
            }

        }
        CompareCellData(prevCellData,currentCellData)
        {
            let compare = (prevCellData.Data == currentCellData.Data && this.CompareInfo(prevCellData.FormatInfo, currentCellData.FormatInfo) )
                
           if (compare)
           {
               console.log(compare);
           }
           return compare;
            
        }
    }
}