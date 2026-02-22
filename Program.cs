namespace VOC_simulator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Menu.showIntro();
            Registration.signUp("Vasya228", "228");
            RegBase.selectLoginAndPassword();
            Capitan capitan = new Capitan();
            string api = Menu.getApiKey();
            await capitan.goToExpedition("Amsterdam", api);
        }
    }
}
