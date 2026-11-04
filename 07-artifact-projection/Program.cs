
List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Select til tre ulike projeksjoner.
var artifactName = artifacts.Select(artifact => artifact.Name);
foreach(var artifact in artifactName)
{
    Console.WriteLine(artifact);
}

var aRisk = artifacts.Select(artifact => artifact.Risk);
foreach(int risk in aRisk)
{
    Console.WriteLine(risk);
}

var aForm = artifacts.Select(artifact => $"{artifact.Name} ({artifact.Origin})");
foreach(var form in aForm)
{
    Console.WriteLine(form);
}