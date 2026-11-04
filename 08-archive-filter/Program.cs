List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Lag tre separate Where-queries.
var hRisk = artifacts.Where(artifact => artifact.Risk >=60);
foreach(var risk in hRisk)
{
    Console.WriteLine($"High risk artifact: {risk.Name}");
}

var aOrigin = artifacts.Where(artifact => artifact.Origin == "Moon");
foreach (var origin in aOrigin)
{
    Console.WriteLine($"Origin Moon: {origin.Name}");
}

var containsE = artifacts.Where(artifact => artifact.Name.Contains("e",StringComparison.CurrentCultureIgnoreCase));
foreach(var e in containsE)
{
    Console.WriteLine($"Contains 'e': {e.Name}");
}