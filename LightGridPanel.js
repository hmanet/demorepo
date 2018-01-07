"use strict";
{
    // Namespace import
    let Core = Carina.Core;
    let Grid = Carina.LightGrid;

     Carina.LightGrid.LightGridPanel = class extends Core.BaseControl
    {
        constructor(parent)
        {
            super();

            this.Parent = parent;
            this.cells = [];
            this.isFirstRender = true;

            this.Element = document.createElement("div");
            this.Element.setAttribute("name", "LightGridPanel");
            this.Element.style["overflow"] = "hidden";
            this.Element.style["position"] = "relative";
            this.Element.style["z-index"] = Grid.LightGrid.PanelZIndex;
            this.tempSnapshot = null;
           
        }

        Reset()
        {
            this.cells = [];
            this.isFirstRender = true;
            //this.Element.style["margin-top"] = this.Parent.Header.Height + "px";
            this.Height = this.Parent.Height - this.Parent.Header.Height;
            this.tempSnapshot = null;
        }

        Render(snapshot)
        {
            console.log(snapshot);
            if (this.isFirstRender)
            {
                this.isFirstRender = false;
                
                let headerSize = new Grid.LightGridColumnHeader(this.Parent.Spec, snapshot.Columns);

                this.Width = headerSize.width;

                for (let i = 0; i < snapshot.Cells.length; i++)
                {
                    let cell = new Grid.LightGridCell(snapshot.Cells[i]);
                    this.Element.appendChild(cell.Element);
                    this.cells.push(cell);
                    cell.Render(snapshot.Cells[i], snapshot.Columns[snapshot.Cells[i].ColumnIndex]);
                }
                this.tempSnapshot = snapshot;
            }
            else
            {

                for (let i = 0, len = snapshot.Cells.length; i !== len; i++)
                {
                     this.cells[i].innerText = snapshot.Cells[i].Data;
                    let compare = this.cells[i].CompareCellData(this.tempSnapshot.Cells[i], snapshot.Cells[i])
                    if (!compare)
                    {
                        this.cells[i].Render(snapshot.Cells[i], snapshot.Columns[snapshot.Cells[i].ColumnIndex]);
                    }
                }
                this.tempSnapshot = snapshot;
            }
        }
    }
}