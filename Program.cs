namespace VOC_simulator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Menu.showIntro();
            Menu.signUp("Vasya228", "228");
            Base.selectLoginAndPassword();
            Capitan capitan = new Capitan();
            string api = Menu.getApiKey();
            await capitan.goToExpedition("Amsterdam", api);
        }
    }
}
