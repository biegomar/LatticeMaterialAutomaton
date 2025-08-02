using LatticeGasAutomata.Cells;

namespace LatticeGasAutomata.Playgrounds;

public sealed class Playground
{
    private readonly Cell[] cells;
    
    private readonly uint dimensionX;
    private readonly uint dimensionY;
    
    public Vector Dimension { get; }

    public Playground(Vector dimension)
    {
        this.Dimension = dimension;
        this.dimensionX = (uint)dimension.X;
        this.dimensionY = (uint)dimension.Y;
        this.cells = new Cell[dimensionX * dimensionY];
    }
    
    public Cell GetCell(Vector position)
    {
        return cells[this.GetIndex(position)]; 
    }

    public void SetCell(Vector position, Cell cell)
    {
        if (IsWithinBounds(position))
        {
            cells[this.GetIndex(position)] = cell;    
        }
    }
    
    private uint GetIndex(Vector position)
    {
        return (uint)position.Y * dimensionX + (uint)position.X;
    }
    
    private bool IsWithinBounds(Vector position)
    {
        return (uint)position.X < dimensionX && (uint)position.Y < dimensionY;
    }
}