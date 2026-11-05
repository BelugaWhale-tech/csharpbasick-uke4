public class ArtifactService
{
    
private List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Cold Lens", "Europa", 28)
};

public List <Artifact> GetArtifacts()
    {
        return artifacts;
    }

public List<Artifact> HighRisk()
    {
        return artifacts
                .Where(artifact => artifact.Risk >= 60)
                .ToList();
    }
public List<Artifact> SearchOrigin(string origin)
    {
        return artifacts
                .Where(artifact => artifact.Origin.Equals(origin,StringComparison.OrdinalIgnoreCase))
                .ToList();
    }







}