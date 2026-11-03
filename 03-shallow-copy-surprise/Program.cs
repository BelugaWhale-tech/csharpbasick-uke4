DroneVault vault = new DroneVault();
vault.Add(new Drone("Delta"));
vault.Add(new Drone("Echo"));

List<Drone> copy = vault.GetDrones();

// TODO: Eksperimenter med RemoveAt og deretter endring av Name.



copy[1].Name = "Changed";
copy.RemoveAt(0);
vault.PrintAll();
Console.WriteLine($"Vault count: {vault.Count}");
Console.WriteLine($"Copy count: {copy.Count}");
