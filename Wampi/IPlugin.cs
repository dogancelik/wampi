namespace Wampi
{
    public interface IPlugin
    {
        MainForm MainForm { get; set; }

        void Load();

        void Unload();
    }
}