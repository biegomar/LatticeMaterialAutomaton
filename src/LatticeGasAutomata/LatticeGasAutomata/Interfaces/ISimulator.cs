namespace LatticeGasAutomata.Interfaces;

public interface ISimulator
{
    IPlayground Propagate(IPlayground current);
    IPlayground Collide(IPlayground current);
}