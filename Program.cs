namespace VOC_simulator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            RegBase.DeleteSQLiteDatabase("saves.db");
            Menu.showIntro();
            //Registration.signUp("Vasya228", "228");
            RegBase.selectAllLoginAndPassword();
            Capitan capitan = new Capitan();
            string api = Menu.getApiKey();
            await capitan.goToExpedition("Amsterdam", api);
        }
    }
}
