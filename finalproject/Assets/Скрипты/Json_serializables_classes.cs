/*THATS JSON CLASSES FOR SERIALISATION*/

namespace json_serializables_classes
{
    [System.Serializable]
    public class Resources
    {
        public ulong honey = 0;
        public ulong crystals = 0;
    }

    [System.Serializable]
    public class Resources_changed
    {
        public string honey_changed = "0";
        public string crystals_changed = "0";
    }

    [System.Serializable]
    public class Player
    {
        public string name;
        public Resources resources = null;
    }

    [System.Serializable]
    public class Shop
    {
        public string name;
        public Resources resources = null;
    }

    [System.Serializable]
    public class Update_resources
    {
        public Resources resources;
    }

    [System.Serializable]
    public class Player_log
    {
        public string comment;
        public string player_name;
        public Resources_changed resources_changed;
    }

    [System.Serializable]
    public class Shop_log
    {
        public string comment;
        public string player_name;
        public string shop_name;
        public Resources_changed resources_changed;
    }
}