List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


var result = artifacts.Where(artifacts => artifacts.Risk >= 30)
                      .OrderBy(artifacts => artifacts.Name)
                      .Select(artifacts => $"{artifacts.Name}: {artifacts.Risk}");
foreach(string artifact in result)
{
    Console.WriteLine(artifact);
}

var sortall = artifacts.OrderBy(artifacts => artifacts.Risk);
foreach(var artifact in sortall)
{
    Console.WriteLine($" Artifact risk: {artifact.Risk} Artifact name: {artifact.Name}");
}


