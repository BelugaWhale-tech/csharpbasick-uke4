ArtifactArchive archive = new ArtifactArchive();
archive.Add(new Artifact("Echo Stone", "Moon", 73));
archive.Add(new Artifact("Broken Compass", "Earth", 12));
archive.Add(new Artifact("Glass Seed", "Mars", 48));
archive.Add(new Artifact("Signal Cube", "Moon", 91));

// TODO: Kall FindArtifacts med minst tre forskjellige lambdas.
List<Artifact> highRisk = archive.FindArtifacts(artifact => artifact.Risk>=60);
foreach(Artifact artifact in highRisk)
{
    Console.WriteLine(artifact.Risk);
}
List<Artifact> thisOrigin = archive.FindArtifacts(artifact => artifact.Origin == "Moon");
foreach(Artifact artifact in thisOrigin)
{
    Console.WriteLine(artifact.Origin);
}
List<Artifact> containsE = archive.FindArtifacts(artifact => artifact.Name.Contains("ass"));
foreach(Artifact artifact in containsE)
{
    Console.WriteLine(artifact.Name);
}
// kan printe klarere outputs, men hopper vidre til neste oppgave