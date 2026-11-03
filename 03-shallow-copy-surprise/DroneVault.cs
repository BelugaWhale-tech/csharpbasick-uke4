public class DroneVault
{
    private List<Drone> drones = new List<Drone>();
    public int Count => drones.Count;

    public void Add(Drone drone)
    {
        drones.Add(drone);
    }

    public List<Drone> GetDrones()
    {
        List<Drone> copy =new List<Drone>(drones);
        return new List<Drone>(copy);
        //ser at copy kan forenkles, gjør det evt senere :)
    }

    public void PrintAll()
    {
        foreach (Drone drone in drones)
        {
            Console.WriteLine(drone.Name);
        }
    }
}
