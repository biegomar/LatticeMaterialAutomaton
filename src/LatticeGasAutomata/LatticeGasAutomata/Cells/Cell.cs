using LatticeGasAutomata.Materials;

namespace LatticeGasAutomata.Cells;

public readonly struct Cell()
{
    private readonly MaterialType[] materials = new MaterialType[8];
    
    public MaterialType this[Direction direction]
    {
        get => this.materials[(int)direction];
        set => this.materials[(int)direction] = value;
    }

    public bool IsEmpty(Direction direction)
    {
        return this[direction] == MaterialType.Empty;   
    }
}