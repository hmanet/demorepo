using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Wells.Carina.Web.API.Models;


namespace Wells.Carina.Web.API
{
    public static class CarinaSnapShotBuilder
    {
        // just a varibale to hold
        private static SnapShot snapShot = new SnapShot();
        public static void Initialize(int rows)
        {
            snapShot.Columns = new List<LightGridColumn>();
            snapShot.RowCount = rows;
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Density",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight="bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder ="2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Description",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Discovery Date",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Has Atmosphere",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Mass",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Name",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Note",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Orbit Distance (Miles)",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Orbital Period (Days)",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Orbits",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Radius",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Random",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Ranking",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Satellites",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });
            snapShot.Columns.Add(new LightGridColumn()
            {
                ColName = "Type",
                Width = 80,
                Height = 20,
                FormatInfo = new FormatInfo()
                {
                    Editable = true,
                    Foreground = "red",
                    Background = "#00FFFFFF",
                    FontFamily = "verdana",
                    FontWeight = "bold",
                    FontStyle = "oblique",
                    FontSize = "10",
                    Visible = true,
                    Strikethrough = "true",
                    Underline = "true",
                    BlendBackground = "overlay",
                    RowBorder = "1",
                    CellBorder = "2"
                }
            });

            snapShot.Cells = new List<LightGridCell>();
            for (int row = 0; row < rows; ++row)
            {
                for (int i = 0; i < snapShot.Columns.Count; ++i)
                    snapShot.Cells.Add(new LightGridCell()
                    {
                        Data = "Data_"+row,
                        RowIndex = row,
                        ColumnIndex = i
                    });
            }
        }

        public static SnapShot GetSnapShot(ViewPort viewPort)
        {

            int from;
            int to;

            // Boundary condition
            if (viewPort.Offset + viewPort.Size > snapShot.RowCount)
            {
                from = (snapShot.RowCount*snapShot.Columns.Count) - (viewPort.Size*snapShot.Columns.Count);
                to = from + viewPort.Size*snapShot.Columns.Count;
            }
            else
            {
                from = viewPort.Offset*snapShot.Columns.Count;
                to = from + viewPort.Size*snapShot.Columns.Count;
            }

            List<LightGridCell> cells = new List<LightGridCell>();

            for (int i = from; i < to; ++i)
            {
                cells.Add(snapShot.Cells[i]);
            }

            SnapShot tempSnapShot = new SnapShot();
            tempSnapShot.Columns = snapShot.Columns;
            tempSnapShot.Cells = cells;
            tempSnapShot.RowCount = snapShot.RowCount;
            tempSnapShot.RowCellCount = snapShot.Columns.Count;

            // 10,0
            // from = 0,to = 0+10*10

            // 10,1
            // from = 10,to=10+10*10

            //10,2
            //from = 20,to=20+10*10

            return tempSnapShot;
        }
    }

    
}