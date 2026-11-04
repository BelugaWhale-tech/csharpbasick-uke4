List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Any og Count til å svare på spørsmålene.

var hRisk = artifacts.Any(artifacts => artifacts.Risk > 90);
    Console.WriteLine($"Risk greater then 90: {hRisk}");

var aMars = artifacts.Count(artifacts => artifacts.Origin =="Mars");
    Console.WriteLine($"Artifacts from Mars: {aMars}");

var aTotal = artifacts.Count();
    Console.WriteLine($"Number of artifacts: {aTotal}");